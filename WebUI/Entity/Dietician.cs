using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Entity
{
    public class Dietician:IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public string HospitalName { get; set; }
        public int Experience { get; set; }
        public string UniversityName { get; set; }
    }
}