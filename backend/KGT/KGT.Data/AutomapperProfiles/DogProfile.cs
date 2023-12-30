using AutoMapper;
using KGT.Data.DataTransferObjects;
using KGT.Data.Models;

namespace KGT.Data.AutomapperProfiles
{
	public class DogProfile : Profile
	{
		public DogProfile()
		{
			CreateMap<Dog, DogDetails>()
				.ForMember(
					dest => dest.GuideIdAndName,
					opt => opt.MapFrom(src => new IdNameModel { Id = src.Guide.Id, Name = src.Guide.FirstName + " " + src.Guide.LastName})
				)
				.ForMember(
					dest => dest.DogId,
					opt => opt.MapFrom(src => src.Id)
				);
			CreateMap<Dog, DogBasicInfo>()
				.ForMember(
					dest => dest.GuideIdAndName,
					opt => opt.MapFrom(src => new IdNameModel { Id = src.Guide.Id, Name = src.Guide.FirstName + " " + src.Guide.LastName })
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
			CreateMap<DogDetails, Dog>()
				.ForMember(
					dest => dest.Id,
					opt => opt.MapFrom(src => src.DogId)
				);

			CreateMap<AddNewDog, Dog>();
			CreateMap<UpdateDogDetails, Dog>()
				.ForMember(
					dest => dest.Id,
					opt => opt.MapFrom(src => src.DogId)
				);

		}
	}
}
