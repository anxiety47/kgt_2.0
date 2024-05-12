using KGT.API.Services;
using KGT.Data.CosmosDb;
using Microsoft.Azure.Cosmos;

namespace KGT.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //if (builder.Environment.IsDevelopment())
            //{
            //    builder.Services.AddSingleton<CosmosClient>((_) =>
            //    {
            //        CosmosClientOptions clientOptions = new CosmosClientOptions()
            //        {
            //            SerializerOptions = new CosmosSerializationOptions()
            //            {
            //                PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase
            //            }
            //        };

            //        CosmosClient client = new(
            //            accountEndpoint: "https://localhost:8081/",
            //            authKeyOrResourceToken: "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
            //            clientOptions: clientOptions
            //        );
            //        return client;
            //    });
            //}
            //else
            //{
            //    builder.Services.AddSingleton<CosmosClient>((_) =>
            //    {
            //        // TODO keyvault
            //        CosmosClient client = new CosmosClient(
            //            connectionString: "<connectionstring>"
            //        );
            //        return client;
            //    });
            //}

            
            var section = builder.Configuration.GetSection("CosmosDb");
            builder.Services.AddSingleton<CosmosClient>(
                InitializeCosmosClientInstanceAsync(section).GetAwaiter().GetResult());



            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddScoped<IDogsService, DogsService>();
            builder.Services.AddScoped<IDogsRepository, DogsRepository>();
            builder.Services.AddScoped<ITrainingsService, TrainingsService>();
            builder.Services.AddScoped<ITrainingsRepository, TrainingsRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        static async Task<CosmosClient> InitializeCosmosClientInstanceAsync(IConfigurationSection configurationSection)
        {
            var databaseName = configurationSection["DatabaseName"];
            var containerNames = configurationSection["ContainerNames"];
            var account = configurationSection["Account"];
            var key = configurationSection["Key"];

            CosmosClientOptions clientOptions = new CosmosClientOptions()
            {
                SerializerOptions = new CosmosSerializationOptions()
                {
                    PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase
                }
            };

            var client = new CosmosClient(account, key, clientOptions);

            var database = await client.CreateDatabaseIfNotExistsAsync(databaseName);
            if(!string.IsNullOrEmpty(containerNames))
            {
                foreach (var containerName in containerNames.Split(","))
                {
                    await database.Database.CreateContainerIfNotExistsAsync(containerName, "/id");

                }
            }
            
            return client;
        }
    }
}