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
        private readonly IMakeServices _makeServices;

        public MakesApi(IMakeServices makeServices)
        {
            _makeServices = makeServices;
        }
        // GET: api/<MakesApi>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _makeServices.GetAsync());
        }

        // GET api/<MakeApi>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var make = await _makeServices.GetAsync(id);
            if (make == null) return NotFound();
            return Ok(make);
        }
        // POST api/<MakesApi>
        [HttpPost]
        public async Task<IActionResult> Get([FromBody] MakeDto make)
        {
            return Ok(await _makeServices.PostAsync(make));
        }

        // PUT api/<MakesApi>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] MakeDto makeDto)
        {
            var make = await _makeServices.PutAsync(makeDto);
            if (make == null) return NotFound();
            return Ok(make);
        }

        // DELETE api/<MakesApi>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var make = await _makeServices.DeleteAsync(id);
            if (!make) return NotFound();
            return Ok(make);
        }
    }
}
