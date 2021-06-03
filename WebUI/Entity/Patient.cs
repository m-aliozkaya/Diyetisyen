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
        public string Name { get; set; }
        public string TcNo { get; set; }
        public IDisease disease { get; set; }
        public Diet diet { get; set; }
    }
}