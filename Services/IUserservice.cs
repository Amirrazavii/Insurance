using Insurance.Models;

namespace Insurance.Services
{
    public interface IUserservice
    {
         public List<User> GetAll();

         public User GetOne(int id);

         public User Create(User user);


         public User Update(int id,User user);


         public Boolean delete(int id);
    }
}