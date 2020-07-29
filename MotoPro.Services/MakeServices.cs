using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MotoPro.Models.Database;
using MotoPro.Services;
using MotoPro.Services.Dto;
using MotoPro.Services.Interfaces;

namespace MotoPro.Services  
{
    public class MakeServices : IMakeServices
    {
        private IMapper _mapper;
        private MotoProDbContext _motoProDbContext;
        public MakeServices(MotoProDbContext motoProDbContext, IMapper mapper)
        {
            _motoProDbContext = motoProDbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Make>> GetAsync()
        {
            return _mapper.Map<List<Make>>(await _motoProDbContext.Makes.Include(x => x.Models).ToListAsync());
        }

        public async Task<IEnumerable<Make>> GetAsync(Make t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            throw new NotImplementedException();
        }

        public async Task<Make> GetAsync(int id)
        {
            return _mapper.Map<Make>(await _motoProDbContext.Makes.SingleOrDefaultAsync(x => x.Id == id));
        }

        public async Task<Make> PostAsync(Make t)
        {
            var make = _mapper.Map<Models.Make>(t);
            await _motoProDbContext.Makes.AddAsync(make);
            await _motoProDbContext.SaveChangesAsync();
            return _mapper.Map<Make>(make);
        }

        public async Task<Make> PutAsync(Make t)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Make t)
        {
            throw new NotImplementedException();
        }
    }
}
