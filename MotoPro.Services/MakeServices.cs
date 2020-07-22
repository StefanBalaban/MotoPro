using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IEnumerable<Make> Get()
        {
            return _motoProDbContext.Makes.Include(x => x.Models).Select(x => _mapper.Map<Make>(x));
        }

        public IEnumerable<Make> Get(Make t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));
            throw new NotImplementedException();
        }

        public Make Get(int id)
        {
            return _mapper.Map<Make>(_motoProDbContext.Makes.SingleOrDefault(x => x.Id == id));
        }

        public Make Post(Make t)
        {
            throw new NotImplementedException();
        }

        public Make Put(Make t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Make t)
        {
            throw new NotImplementedException();
        }
    }
}
