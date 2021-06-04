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
        private Claims GetClaimByUser(IUser user)
        {
            var type = user.GetType().Name;
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

        public Claims Login(string userName, string password)
        {
            var result = _users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            if (result == null)
            {
                return Claims.Null;
            }
            return GetClaimByUser(result);
        }

        public void AddPatient(Patient patient)
        {
            InMemory.Memory.AddPatient(patient);
        }
        public void AddDieticion(Dietician dietician)
        {
            InMemory.Memory.AddDieticion(dietician);
        }
    }
}