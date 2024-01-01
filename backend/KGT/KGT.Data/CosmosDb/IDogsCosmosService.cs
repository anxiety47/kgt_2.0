using KGT.Data.Models.Dogs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KGT.Data.CosmosDb;

public interface IDogsCosmosService
{
    public Task<IEnumerable<Dog>> RetrieveAllDogsAsync();
    public Task<Dog> RetrieveDogInfoAsync(Guid id);
}