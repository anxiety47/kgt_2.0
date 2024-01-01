using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace KGT.Data.CosmosDb;

public abstract class BaseCosmosService
{
    protected readonly CosmosClient _client;
    protected readonly IConfiguration _configuration;

    public BaseCosmosService(CosmosClient cosmosClient, IConfiguration configuration)
    {
        _client = cosmosClient;
        _configuration = configuration;
    }

    protected Database Database
    {
        get => _client.GetDatabase(_configuration["CosmosDb:DatabaseName"]);
    }

    protected Container GetContainerByName(string containerName)
    {
        return _client.GetContainer(this.Database.Id, containerName);
    }

}