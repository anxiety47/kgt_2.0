using KGT.Data.Models.Dogs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb;

public interface IDogsRepository
{
    public Task<IEnumerable<Dog>> GetDogsAsync();
    public Task<Dog> GetDogAsync(Guid id);
    public Task<Dog> CreateDogAsync(Dog dog);
    public Task<Dog> UpdateDogAsync(Guid id, Dog dog);
    public Task DeleteDogAsync(Guid id);
}