using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Entity.Diets.Concrete
{
    public class GlutenFree : Diet
    {
        private const int id = 1;
        private const string dietName = "Gluten Free";
        private const string dietDescription = "Gluten Free Açıklaması";
        public GlutenFree() : base(dietName, dietDescription,id)
        {

        }
    }
}