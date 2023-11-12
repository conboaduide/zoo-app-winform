using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject
{
    public class UserDAO
    {
        private static UserDAO instance = null;

        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }

        public User CheckLogin(string username, string password)
        {
            using var db = new ZooManagementContext();
            return db.Users.Include(u => u.UserRoles).SingleOrDefault(
                a => a.Username.Equals(username)
                && a.Password.Equals(password));
        }
    }

}