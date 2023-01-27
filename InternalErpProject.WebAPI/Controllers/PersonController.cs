using InternalErpProject.WebAPI.Models;
using InternalErpProject.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InternalErpProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IRepository _repo;

        public PersonController(IRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public IActionResult Get()
        {
            var people = _repo.GetAllPeople();
            return Ok(people);
        }

        // GET api/<PersonController>/5
        [HttpGet("{idPerson}")]
        public IActionResult Get(int idPerson)
        {
            var person = _repo.GetPersonByIdPerson(idPerson);
            return Ok(person);
        }

        // POST api/<PersonController>
        [HttpPost]
        public IActionResult Post(PersonModel request)
        {
            _repo.Add<PersonModel>(request);
            if (_repo.SaveChanges())
            {
            return Ok();  
            }

            return BadRequest("Erro");
        }

        // PUT api/<PersonController>/5
        [HttpPut("{idPerson}")]
        public IActionResult Put(int idPerson, PersonModel request)
        {
            request.IdPerson = idPerson;

            _repo.Update<PersonModel>(request);
            if (_repo.SaveChanges())
            {
                return Ok(request);
            }

            return BadRequest("Erro");
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{idPerson}")]
        public IActionResult Delete(int idPerson)
        {
            var person = _repo.GetPersonByIdPerson(idPerson);

            _repo.Delete(person);
            if (_repo.SaveChanges())
            {
                return Ok();
            }

            return BadRequest("Erro");
        }
    }
}
