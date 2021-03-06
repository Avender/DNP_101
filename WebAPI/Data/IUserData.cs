﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IUserData
    {
        public Task<IList<User>> getUsers();

        public Task AddUser(User user);
    }
}