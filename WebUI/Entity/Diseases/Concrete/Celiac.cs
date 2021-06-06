using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diseases.Abstract;

namespace WebUI.Entity.Diseases.Concrete
{
    public class Celiac: Disease
    {
        private const int id = 1;
        private const string dietName = "Çölyak";
        private const string dietDescription = "Çölyak Açıklaması";
        public Celiac() : base(dietName, dietDescription, id)
        {

        }
    }
}