using SFM_DataAccessLayer.Models;
using System.Linq;

namespace SFM_DataAccessLayer
{
    public class Repository
    {
        private FacilityManagementDbContext context;

        public Repository(FacilityManagementDbContext context)
        {
            this.context = context;
        }


        //User Crud
        public bool AddUser(User user)
        {
            if (user == null)
            {
                return false;
            }
            context.Users.Add(user);
            context.SaveChanges();
            return true;    
        }
        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }


        public bool UpdateUser(User user)
        {
            if (user == null)
            {
                return false;
            }
            context.Users.Update(user);
            context.SaveChanges();
            return true;
        }
        public bool RemoveUser(int userId)
        {
            var user = context.Users.Find(userId);
            if (user == null)
            {
                return false;
            }
            context.Users.Remove(user);
            context.SaveChanges();
            return true;
        }

       

        //Authentication Methods
        public bool AuthenticateUser(IUserCredentials user)
        {
            bool status = context.Users.Any(u =>
                u.Email == user.EmailId &&
                u.Password == user.Password);

            return status;
        }
    }
}
