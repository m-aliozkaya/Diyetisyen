using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;
using WebUI.Entity.Diseases.Abstract;

namespace WebUI.Entity
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public IDisease Disease { get; set; }
        public Diet Diet { get; set; }
        public Dietician Dietician { get; set; }
    }
}