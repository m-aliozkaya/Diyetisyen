using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Entity.Diets.Concrete
{
    public class Mediterranean: Diet
    {
        private const int id = 2;
        private const string dietName = "Akdeniz Diyeti";
        private const string dietDescription = "Akdeniz diyeti açıklaması";
        public Mediterranean() : base(dietName, dietDescription,id)
        {

        }
    }
}