using Microsoft.AspNetCore.Mvc;
using Insurance.Services;
using Insurance.Models;

namespace Insurance.Controllers
{

    [ApiController]
    [Route("Api/[controller]")]
    public class UserController:ControllerBase
    {

        Userservice instanceuser=new Userservice();
        [HttpGet("{id}")]
        public User get(int id){

            return instanceuser.GetOne(id);

        }

        [HttpPost("{id}")]

        public User create(int id,User body)
        {
            return instanceuser.Create(body);
        }
        [HttpPut("{id}")]
        public User Update(int id,User body)
        {
           return instanceuser.Update(id,body); 
        }
        [HttpDelete("{id}")]
        public Boolean Delete(int id)
        {
            return instanceuser.delete(id);
        } 
        [HttpGet]
        public List<User> getAll()
        {
            return instanceuser.GetAll();
        } 

    }
}