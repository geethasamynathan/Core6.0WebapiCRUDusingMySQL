using Microsoft.AspNetCore.Mvc;
using secondAPi.Models;
using secondAPi.Repository;

namespace secondAPi.Controllers
{
    [ApiController]
[Route("[controller]")]
    public class OwnerController:ControllerBase
    {
        private IOwnerRepository _repository;
        public OwnerController(IOwnerRepository repository)
        {
            this._repository= repository;

        }
        // GET: api/<UserssController>
        [HttpGet]
        public  IActionResult GetOwners()
        {
            return Ok(_repository.GetAllOwners());  
      }
    

                // GET api/<UserssController>/5
                [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetOwnerById(id));
        }
       

        // POST api/<UserssController>
        [HttpPost]
        public IActionResult AddOwner(Owner owner) 
        {
            
            _repository.AddNewOwner(owner);
           
            return Ok(owner);
        }

        // PUT api/<UserssController>/5
        [HttpPut("{id}")]
        public void Put(Owner owner)
        {
          _repository.UpdateOwnerinfo(owner);
        }

        // DELETE api/<UserssController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.RemoveOwner(id);
        }
        
    }
}