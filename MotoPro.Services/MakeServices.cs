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
    public class MakeServices : IMakeServices
    {
        private IAsyncRepository<Make> _dbContext;
        private IMapper _mapper;

        public MakeServices(IMapper mapper, IAsyncRepository<Make> dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<MakeDto>> GetAsync()
        {
            return _mapper.Map<List<MakeDto>>(await _dbContext.ListAllAsync(new List<string> { "Models" }));
        }

        public async Task<IEnumerable<MakeDto>> GetAsync(MakeDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var make = _mapper.Map<Make>(t);
            return _mapper.Map<List<MakeDto>>(
                (await _dbContext.ListAllAsync(new List<string> { "Models" }))
                    .Where(x => x.Name == make.Name));
        }

        public async Task<MakeDto> GetAsync(int id)
        {
            return _mapper.Map<MakeDto>(await _dbContext.GetByIdAsync(id, new List<string> { "Models" }));
        }

        public async Task<MakeDto> PostAsync(MakeDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var make = _mapper.Map<Make>(t);
            var makeCreateObject = new Make();
            makeCreateObject.Name = make.Name;

            await _dbContext.AddAsync(makeCreateObject);
            return _mapper.Map<MakeDto>(makeCreateObject);
        }

        public async Task<MakeDto> PutAsync(MakeDto t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            var make = _mapper.Map<Make>(t);
            var makeInDb = await _dbContext.GetByIdAsync(make.Id);
            makeInDb.Name = make.Name;

            await _dbContext.UpdateAsync();
            return _mapper.Map<MakeDto>(makeInDb);
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var makeInDb = await _dbContext.GetByIdAsync(id);
            if (makeInDb == null) return false;
            await _dbContext.DeleteAsync(makeInDb);
            return true;
        }

    }
}
