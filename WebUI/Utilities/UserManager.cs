using System.Collections.Generic;
using System.Linq;
using WebUI.Data;
using WebUI.Entity;

namespace WebUI.Utilities
{
    public class UserManager
    {
        private List<IUser> _users;
        public UserManager()
        {
            _users = InMemory.Memory.GetUsers();
        }
        public Claims GetClaimByUserName(string userName)
        {
            var result = _users.FirstOrDefault(u => u.UserName == userName);
            if (result == null)
            {
                return Claims.Null;
            }
            var type = result.GetType().Name;
            foreach (var claim in typeof(Claims).GetFields())
            {
                if (type == claim.Name)
                {
                    return (Claims)claim.GetValue(claim);
                }
            }
            return Claims.Null;
        }

        public IUser GetByUserName(string userName)
        {
            var result = _users.FirstOrDefault(u => u.UserName == userName);
            return result;
        }

        public bool Login(string userName, string password)
        {
            var result = _users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}