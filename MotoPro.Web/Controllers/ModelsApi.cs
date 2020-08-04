using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotoPro.Services.Dto;
using MotoPro.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoPro.Web.Controllers
{
    [Route("api/models")]
    [ApiController]
    public class ModelsApi : ControllerBase
    {
        private readonly IModelServices _modelServices;

        public ModelsApi(IModelServices modelServices)
        {
            _modelServices = modelServices;
        }
        // GET: api/<ModelsApi>
        [HttpGet]
        public async Task<IEnumerable<ModelDto>> Get()
        {
            return await _modelServices.GetAsync();
        }

        // GET api/<ModelApi>/5
        [HttpGet("{id}")]
        public async Task<ModelDto> Get(int id)
        {
            return await _modelServices.GetAsync(id);
        }
        // POST api/<ModelsApi>
        [HttpPost]
        public async Task<IEnumerable<ModelDto>> Get([FromBody] ModelDto model)
        {
            return await _modelServices.GetAsync(model);
        }

        // POST api/<ModelsApi>
        [HttpPost]
        public async Task<ModelDto> Post([FromBody] ModelDto model)
        {
            return await _modelServices.PostAsync(model);
        }

        // PUT api/<ModelsApi>/5
        [HttpPut("{id}")]
        public async Task<ModelDto> Put(int id, [FromBody] ModelDto model)
        {
            return await _modelServices.PutAsync(model);
        }

        // DELETE api/<ModelsApi>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _modelServices.DeleteAsync(id);
        }
    }
}
