using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MotoPro.Models.Database;
using MotoPro.Services.Dto;
using MotoPro.Services.Interfaces;

namespace MotoPro.Services
{
    public class FeatureServices : IFeatureServices
    {
        private MotoProDbContext _motoProDbContext;
        private IMapper _mapper;
        public FeatureServices(IMapper mapper, MotoProDbContext motoProDbContext)
        {
            _mapper = mapper;
            _motoProDbContext = motoProDbContext;
        }
        public IEnumerable<Feature> Get()
        {
            return _motoProDbContext.Features.Select(x => _mapper.Map<Feature>(x));
        }

        public IEnumerable<Feature> Get(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature Get(int id)
        {
            throw new NotImplementedException();
        }

        public Feature Post(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature Put(Feature t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
