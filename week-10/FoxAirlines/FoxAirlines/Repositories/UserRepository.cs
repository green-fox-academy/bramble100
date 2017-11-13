using FoxAirlines.Entities;
using System.Linq;

namespace FoxAirlines.Repositories
{
    public class UserRepository
    {
        public UserContext UserContext { get; set; }

        public UserRepository(UserContext userContext) 
            => UserContext = userContext;

        public bool ContainsUser(string userInput) 
            => UserContext.Users.Any(u => u.LoginName == userInput);
    }
}
