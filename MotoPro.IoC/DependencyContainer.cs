using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MotoPro.Data;
using MotoPro.Services;
using MotoPro.Services.Dto;
using MotoPro.Services.Interfaces;

namespace MotoPro.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutomaperProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddTransient<IMakeServices, MakeServices>();
            services.AddTransient<IFeatureServices, FeatureServices>();
            services.AddTransient<IModelServices, ModelServices>();
        }
    }
}
