using AutoMapper;
using KGT.Data.DataTransferObjects;
using KGT.Data.DbContexts;
using KGT.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KGT.Data.Repositories
{
    public class DogsRepository : RepositoryBase<Dog, int>, IDogsRepository
    {
        private readonly IMapper _mapper;

        public DogsRepository(AppDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public List<DogBasicInfo> GetAllDogsBasicInfo()
        {
            var dogs = GetAll();
            List<DogBasicInfo> dogsBasicInfoList = _mapper.Map<List<Dog>, List<DogBasicInfo>>(dogs);
            return dogsBasicInfoList;
        }

        public async Task<DogDetails> GetDogDetails(int id)
        {
            var dog = await Context.Dogs.FindAsync(id);
            if (dog == null)
                return null;
            var dogDetails = _mapper.Map<DogDetails>(dog);
            return dogDetails;
        }

        public async Task<int> AddAsync(AddNewDog newDogDetails)
        {
            var guide = await Context.Guides.FindAsync(newDogDetails.GuideId);
            if (guide == null)
            {
                throw new System.Exception($"Guide with id {newDogDetails.GuideId} was not found");
            }
            var dog = _mapper.Map<Dog>(newDogDetails);
            dog.Guide = guide;
            return await this.AddAsync(dog);
        }

        public async Task UpdateAsync(UpdateDogDetails updatedDetails)
        {
            var dog = _mapper.Map<Dog>(updatedDetails);
            await this.ModifyAsync(dog);
        }
    }
}
