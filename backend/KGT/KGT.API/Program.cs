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

            if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddSingleton<CosmosClient>((_) =>
                {
                    // TODO emulator?
                    CosmosClient client = new CosmosClient(
                        connectionString: "<connectionstring>"
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
                        connectionString: "<connectionstring>"
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