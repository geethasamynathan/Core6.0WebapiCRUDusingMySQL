
using Microsoft.AspNetCore.Mvc;
using secondAPi.Models;
using secondAPi.Repository;


namespace secondAPi.Controllers
{
  [ApiController]
[Route("[controller]")]
    public class AccountController:ControllerBase
    {
        private IAccountRepository _repository;
        public AccountController(IAccountRepository repository)
        {
            this._repository= repository;

        }
        // GET: api/<UserssController>
        [HttpGet]
        public  IActionResult GetAccounts()
        {
            return Ok(_repository.GetAllAccounts());  
      }
    

                // GET api/<UserssController>/5
                [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetAccountById(id));
        }
       

        // POST api/<UserssController>
        [HttpPost]
        public IActionResult AddUser(Account account) 
        {
            
            _repository.AddNewAccounts(account);
           
            return Ok(account);
        }

        // PUT api/<UserssController>/5
        [HttpPut("{id}")]
        public void Put(Account account)
        {
          _repository.UpdateAccountinfo(account);
        }

        // DELETE api/<UserssController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
         
            _repository.RemoveAccount(id);
        }
    }
}