using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MotoPro.Services.Dto;
using MotoPro.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoPro.Web.Controllers
{
    
    [Route("api/makes")]
    [ApiController]
    public class MakesApi : ControllerBase
    {
        private IMakeServices _makeServices;

        public MakesApi(IMakeServices makeServices)
        {
            _makeServices = makeServices;
        }
        // GET: api/<MakesApi>
        [HttpGet]
        public async Task<IEnumerable<Make>> Get()
        {
            return await _makeServices.GetAsync();
        }

        // GET api/<MakesApi>/5
        [HttpGet("{id}")]
        public async Task<Make> Get(int id)
        {
            return await _makeServices.GetAsync(id);
        }

        // POST api/<MakesApi>
        [HttpPost]
        public async Task<Make> Post([FromBody] Make make)
        {
            return await _makeServices.PostAsync(make);
        }

        // PUT api/<MakesApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MakesApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
