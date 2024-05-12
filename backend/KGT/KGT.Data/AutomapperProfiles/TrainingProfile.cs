using AutoMapper;
using KGT.Data.Models.Trainings;
using KGT.Data.DataTransferObjects.Trainings;
using KGT.Data.Models.DogTrainings;
namespace KGT.Data.AutomapperProfiles
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<Training, TrainingDetails>()
                .ForMember(
                    dest => dest.DogTrainings,
                    opt => opt.MapFrom(src => src.DogTrainings)
                );

            CreateMap<Training, TrainingBasicInfo>();
            
            CreateMap<TrainingDetails, Training>();

            CreateMap<AddNewTraining, Training>();
            
            CreateMap<DogTrainingBasicInfo, DataTransferObjects.DogTrainings.DogTrainingBasicInfo>()
                .ReverseMap();
        }
    }

}