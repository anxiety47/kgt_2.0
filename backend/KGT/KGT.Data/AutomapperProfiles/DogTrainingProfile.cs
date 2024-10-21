using AutoMapper;
using KGT.Data.Models.DogTrainings;
using KGT.Data.DataTransferObjects.DogTrainings;
namespace KGT.Data.AutomapperProfiles
{
    public class DogTrainingProfile : Profile
    {
        public DogTrainingProfile()
        {
            CreateMap<DogTraining, DogTrainingDetails>().ReverseMap();

            CreateMap<DogTraining, DogTrainingBasicInfo>().ReverseMap();

            // TODO can we automap this property? This might be difficult with the gpx files etc.
            CreateMap<AddNewDogTraining, DogTraining>();
        }
    }

}