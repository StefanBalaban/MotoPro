using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MotoPro.Models;
using MotoPro.Services.Dto;
using MotoPro.Services.Interfaces;

namespace MotoPro.Services
{
    public class ModelServices : IModelServices
    {
        private IAsyncRepository<Model> _dbContext;
        private IMapper _mapper;

        public ModelServices(IMapper mapper, IAsyncRepository<Model> dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ModelDto>> GetAsync()
        {
            return _mapper.Map<List<ModelDto>>(await _dbContext.ListAllAsync());
        }

        public async Task<IEnumerable<ModelDto>> GetAsync(ModelDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var model = _mapper.Map<Model>(t);
            return _mapper.Map<List<ModelDto>>((await _dbContext.ListAllAsync())
                .Where(x => x.Name == model.Name && x.MakeId == model.MakeId)
                    );
        }

        public async Task<ModelDto> GetAsync(int id)
        {
            return _mapper.Map<ModelDto>(await _dbContext.GetByIdAsync(id));
        }

        public async Task<ModelDto> PostAsync(ModelDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var model = _mapper.Map<Model>(t);
            await _dbContext.AddAsync(model);
            return _mapper.Map<ModelDto>(model);
        }

        public async Task<ModelDto> PutAsync(ModelDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var model = _mapper.Map<Model>(t);
            var modelInDb = await _dbContext.GetByIdAsync(model.Id);
            modelInDb.Name = model.Name;
            await _dbContext.UpdateAsync();
            return _mapper.Map<ModelDto>(model);
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var modelInDb = await _dbContext.GetByIdAsync(id);
            if (modelInDb == null) return false;
            await _dbContext.DeleteAsync(modelInDb);
            return true;
        }

    }
}
