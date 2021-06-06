using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diseases.Abstract;

namespace WebUI.Entity.Diseases.Concrete
{
    public class Obese: Disease
    {
        private const int id = 3;
        private const string dietName = "Obez";
        private const string dietDescription = "Obez Açıklaması";
        public Obese() : base(dietName, dietDescription, id)
        {

        }
    }
}