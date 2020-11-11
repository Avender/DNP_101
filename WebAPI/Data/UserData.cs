using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class UserData : IUserData
    {

        private FileContext fileContext;
        
        public UserData()
        {
            fileContext = new FileContext();
        }
        
        public async Task<IList<User>> getUsers()
        {
            IList<User> users = fileContext.Users;
            return users;
            
        }

        public async Task AddUser(User user)
        {
            if (fileContext.Users.FirstOrDefault(u => u.Username.Equals(user.Username)) == null)
            {
                fileContext.Users.Add(user);
                fileContext.SaveChanges();
            }
        }
    }
}