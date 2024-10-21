using KGT.Data.Models.DogTrainings;
using KGT.Data.Models.Trainings;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb;

public interface IDogTrainingsRepository
{
    public Task<IEnumerable<DogTraining>> GetDogTrainingsByDogIdAsync(Guid dogId);
    public Task<IEnumerable<DogTraining>> GetDogTrainingsByTrainingIdAsync(Guid trainingId);

    public Task<DogTraining> GetDogTrainingAsync(Guid id);
    public Task<DogTraining> CreateDogTrainingAsync(DogTraining dogTraining);
    public Task<DogTraining> UpdateDogTrainingAsync(Guid id, DogTraining dogTraining);
    public Task DeleteDogTrainingAsync(Guid id);
}