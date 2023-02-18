using Insurance.Models;

namespace Insurance.Services
{
    public class Userservice : IUserservice
    {
        
        InsuranceContext  db_context=new InsuranceContext();


        public User Create(User user)
        {
            User createuser=new User();
            createuser.username = user.username;
            createuser.password = user.password;
           
           db_context.Users.Add(createuser);
           db_context.SaveChanges();

           return user;
        }



        public Boolean delete(int id)
        {
            User userfinde=GetOne(id);

            if(userfinde!=null)
            {
                db_context.Users.Remove(userfinde);
                db_context.SaveChanges();

                return true;
            }

            return false;

            
        }

        public List<User> GetAll()
        {
            List<User> users=db_context.Users.ToList();

            return users;
        }

        public User GetOne(int id)
        {
            User user=db_context.Users.Find(id);

            return user;


        }

        public User Update(int id,User user)
        {
            User userfinde=GetOne(id);
            userfinde.username=user.username;
            userfinde.password=user.password;
            db_context.SaveChanges();

            return userfinde;

        }


    }
}