using AutoMapper;
using KGT.Data.DataTransferObjects;
using KGT.Data.DataTransferObjects.Dogs;
using KGT.Data.Models;
using KGT.Data.Models.Dogs;

namespace KGT.Data.AutomapperProfiles
{
    public class DogProfile : Profile
	{
		public DogProfile()
		{
			CreateMap<Dog, DogDetails>()
				.ForMember(
					dest => dest.GuideIdAndName,
					opt => opt.MapFrom(src => new IdNameModel { Id = src.GuideDetails.GuideId, Name = src.GuideDetails.GuideName })
				)
				.ForMember(
					dest => dest.Trainings,
                    opt => opt.MapFrom(src => src.DogTrainings)
                )
				.ForMember(
                    dest => dest.Events,
                    opt => opt.MapFrom(src => src.DogEvents)
                )
                .ForMember(
                    dest => dest.Certificates,
                    opt => opt.MapFrom(src => src.DogCertificates)
                );

            CreateMap<Dog, DogBasicInfo>()
                .ForMember(
                    dest => dest.GuideIdAndName,
                    opt => opt.MapFrom(src => new IdNameModel { Id = src.GuideDetails.GuideId, Name = src.GuideDetails.GuideName })
                );
            // TODO move to GuideProfile?
            CreateMap<Guide, IdNameModel>()
				.ForMember(
					dest => dest.Id,
					opt => opt.MapFrom(src => src.Id)
				)
				.ForMember(
					dest => dest.Name,
					opt => opt.MapFrom(src => src.FirstName + " " + src.LastName)
				);
			CreateMap<DogDetails, Dog>();

			CreateMap<AddNewDog, Dog>();
			CreateMap<UpdateDogDetails, Dog>()
				.ForMember(
					dest => dest.Id,
					opt => opt.MapFrom(src => src.DogId)
				);
			CreateMap<Models.Dogs.DogTrainingBasicInfo, DataTransferObjects.Dogs.DogTrainingBasicInfo>()
				.ReverseMap();
            CreateMap<Models.Dogs.DogEventBasicInfo, DataTransferObjects.Dogs.DogEventBasicInfo>()
                .ReverseMap();
            CreateMap<Models.Dogs.DogCertificateBasicInfo, DataTransferObjects.Dogs.DogCertificateBasicInfo>()
                .ReverseMap();
        }
	}
}
