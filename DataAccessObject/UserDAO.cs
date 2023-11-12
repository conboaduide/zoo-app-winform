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
            return db.Users.Where(u => u.Status).SingleOrDefault(
                a => a.Username.Equals(username)
                && a.Password.Equals(password));
        }

        public List<User> GetUsers()
        {
            using var db = new ZooManagementContext();
            return db.Users.ToList();
        }

        public void CreateUser(User newUser)
        {
            using (var db = new ZooManagementContext())
            {
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

        public void UpdateUser(User updatedUser)
        {
            using (var db = new ZooManagementContext())
            {
                var existingUser = db.Users.Find(updatedUser.Id);
                if (existingUser != null)
                {
                    // Update properties of the existing user
                    existingUser.Username = updatedUser.Username;
                    existingUser.Email = updatedUser.Email;
                    existingUser.Role = updatedUser.Role;
                    existingUser.Status = updatedUser.Status;
                    db.SaveChanges();
                }
                else
                {
                    // User not found, handle accordingly (e.g., throw an exception or log a message)
                }
            }
        }

        public void DeleteUser(int userId)
        {
            using (var db = new ZooManagementContext())
            {
                var userToDelete = db.Users.Find(userId);
                if (userToDelete != null)
                {
                    db.Users.Remove(userToDelete);
                    db.SaveChanges();
                }
                else
                {
                    // User not found, handle accordingly (e.g., throw an exception or log a message)
                }
            }
        }
    }

}