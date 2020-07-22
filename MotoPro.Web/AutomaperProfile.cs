using System.Collections.Generic;
using AutoMapper;
using MotoPro.Services.Dto;

namespace MotoPro.Web
{
    class AutomaperProfile : Profile
    {
        public AutomaperProfile()
        {
            CreateMap<Models.Feature, Feature>();
            CreateMap<Models.Make, Make>();
            CreateMap<Models.Model, Model>();
            CreateMap<IEnumerable<Models.Make>, IEnumerable<Make>>();
        }
    }
}
