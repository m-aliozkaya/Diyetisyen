using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diseases.Abstract;

namespace WebUI.Entity.Diseases.Concrete
{
    public class Diabetes: Disease
    {
        private const int id = 2;
        private const string dietName = "Şeker";
        private const string dietDescription = "Şeker Açıklaması";
        public Diabetes() : base(dietName, dietDescription, id)
        {

        }
    }
}