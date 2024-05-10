using KGT.Data.Models.Dogs;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb
{

    public class DogsRepository : BaseCosmosService, IDogsRepository
    {

        public DogsRepository(CosmosClient cosmosClient, IConfiguration configuration) : base(cosmosClient, configuration)
        {
        }

        private Container _container
        {
            get => base.GetContainerByName("Dogs");
        }


        public async Task<IEnumerable<Dog>> GetDogsAsync()
        {
            var query = _container.GetItemQueryIterator<Dog>(new QueryDefinition("SELECT * FROM c"));
            var results = new List<Dog>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task<Dog> GetDogAsync(Guid id)
        {
            try
            {
                var response = await _container.ReadItemAsync<Dog>(id.ToString(), new PartitionKey(id.ToString()));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<Dog> CreateDogAsync(Dog dog)
        {
            var response = await _container.CreateItemAsync(dog, new PartitionKey(dog.Id.ToString()));
            return response.Resource;
        }

        public async Task<Dog> UpdateDogAsync(Guid id, Dog dog)
        {
            var response = await _container.UpsertItemAsync(dog, new PartitionKey(id.ToString()));
            return response.Resource;
        }

        public async Task DeleteDogAsync(Guid id)
        {
            await _container.DeleteItemAsync<Dog>(id.ToString(), new PartitionKey(id.ToString()));
        }
    }
}
