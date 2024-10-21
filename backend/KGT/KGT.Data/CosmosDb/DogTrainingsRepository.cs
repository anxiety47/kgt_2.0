using KGT.Data.Models.Dogs;
using KGT.Data.Models.DogTrainings;
using KGT.Data.Models.Trainings;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb
{
    public class DogTrainingsRepository : BaseCosmosService, IDogTrainingsRepository
    {

        public DogTrainingsRepository(CosmosClient cosmosClient, IConfiguration configuration) : base(cosmosClient, configuration)
        {
        }

        private Container _container
        {
            get => base.GetContainerByName("DogTrainings");
        }

        public async Task<IEnumerable<DogTraining>> GetDogTrainingsByDogIdAsync(Guid dogId)
        {
            var query = _container.GetItemQueryIterator<DogTraining>(new QueryDefinition($"SELECT * FROM c WHERE c.DogId == {dogId}"));
            var results = new List<DogTraining>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task<IEnumerable<DogTraining>> GetDogTrainingsByTrainingIdAsync(Guid trainingId)
        {
            var query = _container.GetItemQueryIterator<DogTraining>(new QueryDefinition($"SELECT * FROM c WHERE c.DogId == {trainingId}"));
            var results = new List<DogTraining>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task<DogTraining> GetDogTrainingAsync(Guid id)
        {
            try
            {
                var response = await _container.ReadItemAsync<DogTraining>(id.ToString(), new PartitionKey(id.ToString()));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<DogTraining> CreateDogTrainingAsync(DogTraining dogTraining)
        {
            var response = await _container.CreateItemAsync(dogTraining, new PartitionKey(dogTraining.Id.ToString()));
            return response.Resource;
        }

        public async Task<DogTraining> UpdateDogTrainingAsync(Guid id, DogTraining dogTraining)
        {
            var response = await _container.UpsertItemAsync(dogTraining, new PartitionKey(id.ToString()));
            return response.Resource;
        }

        public async Task DeleteDogTrainingAsync(Guid id)
        {
            await _container.DeleteItemAsync<DogTraining>(id.ToString(), new PartitionKey(id.ToString()));
        }
    }
}
