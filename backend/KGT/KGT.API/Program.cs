using KGT.API.Services;
using KGT.Data.CosmosDb;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;

namespace KGT.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddDbContext<AppDbContext>(options =>
            //{
            //    options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("KgtDataDb"),
            //    sqlServerOptionsAction: sqlOptions =>
            //    {
            //        sqlOptions.EnableRetryOnFailure(
            //        maxRetryCount: 5,
            //        maxRetryDelay: TimeSpan.FromSeconds(90),
            //        errorNumbersToAdd: null);
            //    });
            //});

            if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddSingleton<CosmosClient>((_) =>
                {
                    // TODO emulator?
                    CosmosClient client = new CosmosClient(
                        connectionString: "AccountEndpoint=https://kgtcosmosdb.documents.azure.com:443/;AccountKey=MEMe3mhQKE73blAKT0doZbigShG1Ig05NgCk9E6iWbX9fJc8Aw5Sn36FIIDMDIn4UOqOis7eog5JACDbLxTpEg==;"
                    );
                    return client;
                });
            }
            else
            {
                builder.Services.AddSingleton<CosmosClient>((_) =>
                {
                    // TODO keyvault
                    CosmosClient client = new CosmosClient(
                        connectionString: "AccountEndpoint=https://kgtcosmosdb.documents.azure.com:443/;AccountKey=MEMe3mhQKE73blAKT0doZbigShG1Ig05NgCk9E6iWbX9fJc8Aw5Sn36FIIDMDIn4UOqOis7eog5JACDbLxTpEg==;"
                    );
                    return client;
                });
            }

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // TODO builder.Services.AddScoped<IDogsRepository, DogsRepository>();
            builder.Services.AddScoped<IDogsService, DogsService>();
            builder.Services.AddScoped<IDogsCosmosService, DogsCosmosService>();

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
    }
}