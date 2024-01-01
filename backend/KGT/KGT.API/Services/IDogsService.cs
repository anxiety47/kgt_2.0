using KGT.Data.DataTransferObjects.Dogs;

namespace KGT.API.Services
{
    public interface IDogsService
    {
        public Task<List<DogBasicInfo>> GetAllDogsBasicInfo();
        public Task<DogDetails> GetDogDetails(Guid id);

    }
}
