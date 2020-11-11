using System.Threading.Tasks;
using Models;

namespace DNP_Assignment.Data
{
    public interface IUserData
    {
        public Task<User> CheckUser(string Username, string Password);

        public Task AddUser(User user);

        public void CheckUserName(User newUser);
    }
}