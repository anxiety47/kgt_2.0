using KGT.Data.DataTransferObjects.Dogs;

namespace KGT.API.Services
{
    public interface IDogsService
    {
        public Task<List<DogBasicInfo>> GetAllDogsBasicInfo();
        public Task<DogDetails> GetDogDetails(Guid id);
        public Task<DogDetails> AddDog(AddNewDog newDog);
        public Task<DogDetails> UpdateDog(DogDetails dogDetails);
        public Task DeleteDog(Guid id);
    }
}
