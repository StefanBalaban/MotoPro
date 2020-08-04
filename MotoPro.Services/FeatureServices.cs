using AutoMapper;
using MotoPro.Models;
using MotoPro.Services.Dto;
using MotoPro.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoPro.Services
{
    public class FeatureServices : IFeatureServices
    {
        private IAsyncRepository<Feature> _dbContext;
        private IMapper _mapper;

        public FeatureServices(IMapper mapper, IAsyncRepository<Feature> dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<FeatureDto>> GetAsync()
        {
            return _mapper.Map<List<FeatureDto>>(await _dbContext.ListAllAsync());
        }

        public async Task<IEnumerable<FeatureDto>> GetAsync(FeatureDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var feature = _mapper.Map<Feature>(t);
            return _mapper.Map<List<FeatureDto>>(
                (await _dbContext.ListAllAsync())
                    .Where(x => x.Name == feature.Name));
        }

        public async Task<FeatureDto> GetAsync(int id)
        {
            return _mapper.Map<FeatureDto>(await _dbContext.GetByIdAsync(id));
        }

        public async Task<FeatureDto> PostAsync(FeatureDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var feature = _mapper.Map<Feature>(t);
            await _dbContext.AddAsync(feature);
            return _mapper.Map<FeatureDto>(feature);
        }

        public async Task<FeatureDto> PutAsync(FeatureDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var feature = _mapper.Map<Feature>(t);
            var featureInDb = await _dbContext.GetByIdAsync(feature.Id);
            featureInDb.Name = feature.Name;
            await _dbContext.UpdateAsync();
            return _mapper.Map<FeatureDto>(feature);
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var featureInDb = await _dbContext.GetByIdAsync(id);
            if (featureInDb == null) return false;
            await _dbContext.DeleteAsync(featureInDb);
            return true;
        }

    }
}
