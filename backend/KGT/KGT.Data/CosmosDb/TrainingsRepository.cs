using KGT.Data.Models.Trainings;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb
{
    public class TrainingsRepository : BaseCosmosService, ITrainingsRepository
    {

        public TrainingsRepository(CosmosClient cosmosClient, IConfiguration configuration) : base(cosmosClient, configuration)
        {
        }

        private Container _container
        {
            get => base.GetContainerByName("Trainings");
        }


        public async Task<IEnumerable<Training>> GetTrainingsAsync()
        {
            var query = _container.GetItemQueryIterator<Training>(new QueryDefinition("SELECT * FROM c"));
            var results = new List<Training>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task<Training> GetTrainingAsync(Guid id)
        {
            try
            {
                var response = await _container.ReadItemAsync<Training>(id.ToString(), new PartitionKey(id.ToString()));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<Training> CreateTrainingAsync(Training training)
        {
            var response = await _container.CreateItemAsync(training, new PartitionKey(training.Id.ToString()));
            return response.Resource;
        }

        public async Task<Training> UpdateTrainingAsync(Guid id, Training training)
        {
            var response = await _container.UpsertItemAsync(training, new PartitionKey(id.ToString()));
            return response.Resource;
        }

        public async Task DeleteTrainingAsync(Guid id)
        {
            await _container.DeleteItemAsync<Training>(id.ToString(), new PartitionKey(id.ToString()));
        }
    }
}
