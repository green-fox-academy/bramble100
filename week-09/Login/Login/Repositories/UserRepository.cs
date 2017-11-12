using Login.Entities;
using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Repositories
{
    public class UserRepository
    {
        public UserContext UserContext { get; set; }

        public UserRepository(UserContext userContext)
        {
            UserContext = userContext;
        }
        public bool UserExists(string userInput) 
            => UserContext.Users.Any(u => u.LoginName == userInput);
    }
}
