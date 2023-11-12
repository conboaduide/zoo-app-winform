using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {
        public User CheckLogin(string username, string password);

        public List<User> GetUsers();

        public void CreateUser(User user);

        public void UpdateUser(User user);

        public void DeleteUser(int id);
    }
}
