using BusinessObject.Models;
using DataAccessObject;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public User CheckLogin(string username, string password)
        => UserDAO.Instance.CheckLogin(username, password);

        public List<User> GetUsers()
        => UserDAO.Instance.GetUsers();

        public void CreateUser(User newUser)
        => UserDAO.Instance.CreateUser(newUser);

        public void UpdateUser(User updatedUser)
        => UserDAO.Instance.UpdateUser(updatedUser);

        public void DeleteUser(int userId)
        => UserDAO.Instance.DeleteUser(userId);
    }
}