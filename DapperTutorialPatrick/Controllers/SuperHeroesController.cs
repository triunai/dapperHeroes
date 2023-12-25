using AutoMapper;
using DapperTutorialPatrick.Models;
using DapperTutorialPatrick.Models.DTOS;
using DapperTutorialPatrick.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperTutorialPatrick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        public IConfiguration _configuration { get; }
        public ISuperHeroesRepository SuperHeroesRepository { get; }
        public IMapper Mapper { get; }

        // read only goes here for injections
        public SuperHeroesController(
            IConfiguration configuration,
            ISuperHeroesRepository superHeroesRepository,
            IMapper mapper
            )
        {
            _configuration = configuration;
            SuperHeroesRepository = superHeroesRepository;
            Mapper = mapper;
        }


        // POST api/<SuperHeroesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }




        // GETALL: api/<SuperHeroesController>
        [HttpGet]
        public async Task<IActionResult> GetAllSupes()
        {

            var heroes = await SuperHeroesRepository.GetAllSuperHeroesAsync();
            var responseWithoutID = Mapper.Map<IEnumerable<SuperHeroesDTO>>(heroes);
            return Ok(responseWithoutID); // placeholder NEEDS CHANGE
        }
        // GET api/<SuperHeroesController>/5
        [HttpGet("{id}")]
        public string GetSingleSuperhero(int id)
        {
            return "value";
        }

        // PUT api/<SuperHeroesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SuperHeroesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
