using AutoMapper;

namespace MotoPro.Services.Dto
{
    public class AutomaperProfile : Profile
    {
        public AutomaperProfile()
        {
            CreateMap<MotoPro.Models.Feature, FeatureDto>();
            CreateMap<MotoPro.Models.Make, MakeDto>();
            CreateMap<MotoPro.Models.Model, ModelDto>();
            CreateMap<MakeDto, MotoPro.Models.Make>();
            CreateMap<ModelDto, MotoPro.Models.Model>();
        }
    }
}
