using System.Collections.Generic;
using AutoMapper;
using MotoPro.Services.Dto;

namespace MotoPro.Web
{
    class AutomaperProfile : Profile
    {
        public AutomaperProfile()
        {
            CreateMap<MotoPro.Models.Feature, Feature>();
            CreateMap<MotoPro.Models.Make, Make>();
            CreateMap<Make, MotoPro.Models.Make>();
            CreateMap<MotoPro.Models.Model, Model>();
        }
    }
}
