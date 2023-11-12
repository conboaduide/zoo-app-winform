using BusinessObject.Models;
using DataAccessObject;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public User CheckLogin(string username, string password)
        => UserDAO.Instance.CheckLogin(username, password);
    }
}