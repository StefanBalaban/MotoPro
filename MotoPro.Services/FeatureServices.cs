using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Feature>> GetAsync()
        {
            return _mapper.Map<List<Feature>>(await _motoProDbContext.Features.ToListAsync());
        }

        public async Task<IEnumerable<Feature>> GetAsync(Feature t)
        {
            throw new NotImplementedException();
        }

        public async Task<Feature> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Feature> PostAsync(Feature t)
        {
            throw new NotImplementedException();
        }

        public async Task<Feature> PutAsync(Feature t)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
