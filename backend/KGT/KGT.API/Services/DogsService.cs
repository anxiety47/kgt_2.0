using AutoMapper;
using KGT.Data.CosmosDb;
using KGT.Data.DataTransferObjects.Dogs;
using KGT.Data.Models.Dogs;

namespace KGT.API.Services
{
    public class DogsService : IDogsService
    {
        private readonly IDogsRepository _dogsRepository;
        private readonly IMapper _mapper;


        public DogsService(IMapper mapper, IDogsRepository dogsRepository) 
        {
            _mapper = mapper;
            _dogsRepository = dogsRepository;
        }

        public async Task<List<DogBasicInfo>> GetAllDogsBasicInfo()
        {
            var dogs = (await _dogsRepository.GetDogsAsync()).ToList();
            List<DogBasicInfo> dogsBasicInfoList = _mapper.Map<List<Dog>, List<DogBasicInfo>>(dogs);
            return dogsBasicInfoList;
        }

        public async Task<DogDetails> GetDogDetails(Guid id)
        {
            var dog = await _dogsRepository.GetDogAsync(id);
            DogDetails dogDetails = _mapper.Map<Dog, DogDetails>(dog);
            return dogDetails;
        }

        public async Task<DogDetails> AddDog(AddNewDog newDog)
        {
            var dog = _mapper.Map<AddNewDog, Dog>(newDog);
            dog.Id = Guid.NewGuid();
            var createdDog = await _dogsRepository.CreateDogAsync(dog);
            DogDetails dogDetails = _mapper.Map<Dog, DogDetails>(createdDog);

            return dogDetails;
        }

        public Task<DogDetails> UpdateDog(DogDetails dogDetails)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDog(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
