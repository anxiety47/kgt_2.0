using KGT.Data.Models.Trainings;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb;

public interface ITrainingsRepository
{
    public Task<IEnumerable<Training>> GetTrainingsAsync();
    public Task<Training> GetTrainingAsync(Guid id);
    public Task<Training> CreateTrainingAsync(Training training);
    public Task<Training> UpdateTrainingAsync(Guid id, Training training);
    public Task DeleteTrainingAsync(Guid id);
}