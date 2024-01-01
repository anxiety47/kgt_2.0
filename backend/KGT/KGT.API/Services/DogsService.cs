using AutoMapper;
using KGT.Data.CosmosDb;
using KGT.Data.DataTransferObjects.Dogs;
using KGT.Data.Models.Dogs;

namespace KGT.API.Services
{
    public class DogsService : IDogsService
    {
        private readonly IDogsCosmosService _dogsCosmosService;
        private readonly IMapper _mapper;


        public DogsService(IMapper mapper, IDogsCosmosService dogsCosmosService) 
        {
            _mapper = mapper;
            _dogsCosmosService = dogsCosmosService;
        }

        public async Task<List<DogBasicInfo>> GetAllDogsBasicInfo()
        {
            var dogs = (await _dogsCosmosService.RetrieveAllDogsAsync()).ToList();
            List<DogBasicInfo> dogsBasicInfoList = _mapper.Map<List<Dog>, List<DogBasicInfo>>(dogs);
            return dogsBasicInfoList;
        }

        public async Task<DogDetails> GetDogDetails(Guid id)
        {
            var dog = await _dogsCosmosService.RetrieveDogInfoAsync(id);
            DogDetails dogDetails = _mapper.Map<Dog, DogDetails>(dog);
            return dogDetails;
        }
    }
}
