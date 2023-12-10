using KGT.Data.DataTransferObjects;
using KGT.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KGT.Data.Repositories
{
    public interface IDogsRepository : IRepository<Dog, int>
    {
        List<DogBasicInfo> GetAllDogsBasicInfo();
        Task<DogDetails> GetDogDetails(int id);
    }
}
