using KGT.Data.Models.Dogs;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb;

public class DogsCosmosService : BaseCosmosService, IDogsCosmosService
{
    public DogsCosmosService(CosmosClient cosmosClient, IConfiguration configuration) 
        : base(cosmosClient, configuration)
    {
    }

    private Container container
    {
        get => base.GetContainerByName("Dogs");
    }

    public async Task<IEnumerable<Dog>> RetrieveAllDogsAsync()
    {
        var queryable = container.GetItemLinqQueryable<Dog>();

        using FeedIterator<Dog> feed = queryable
            .OrderBy(d => d.Name)
            .ToFeedIterator();

        List<Dog> results = new();

        while (feed.HasMoreResults)
        {
            var response = await feed.ReadNextAsync();
            foreach (Dog item in response)
            {
                results.Add(item);
            }
        }

        return results;
    }

    public async Task<Dog> RetrieveDogInfoAsync(Guid id)
    {
        Dog readItem = await container.ReadItemAsync<Dog>(
            id: id.ToString(),
            partitionKey: new PartitionKey(id.ToString())
        );
        return readItem;
    }

    //public async Task<IEnumerable<Dog>> RetrieveDogInfoAsync()
    //{
    //    string sql = """
    //    SELECT
    //        p.id,
    //        p.categoryId,
    //        p.categoryName,
    //        p.sku,
    //        p.name,
    //        p.description,
    //        p.price,
    //        p.tags
    //    FROM products p
    //    JOIN t IN p.tags
    //    WHERE t.name = @tagFilter
    //    """;

    //    var query = new QueryDefinition(
    //        query: sql
    //    )
    //        .WithParameter("@tagFilter", "Tag-75");

    //    using FeedIterator<Dog> feed = container.GetItemQueryIterator<Dog>(
    //        queryDefinition: query
    //    );

    //    List<Dog> results = new();

    //    while (feed.HasMoreResults)
    //    {
    //        var response = await feed.ReadNextAsync();
    //        foreach (Dog item in response)
    //        {
    //            results.Add(item);
    //        }
    //    }

    //    return results;
    //}
}