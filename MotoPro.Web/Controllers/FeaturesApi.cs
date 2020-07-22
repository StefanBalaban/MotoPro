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
    [Route("api/features")]
    [ApiController]
    public class FeaturesApi : ControllerBase
    {
        private IFeatureServices _featureServices;

        public FeaturesApi(IFeatureServices featureServices)
        {
            _featureServices = featureServices;
        }

        // GET: api/<FeaturesApi>
        [HttpGet]
        public IEnumerable<Feature> Get()
        {
            return _featureServices.Get();
        }

        // GET api/<FeaturesApi>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FeaturesApi>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FeaturesApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FeaturesApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
