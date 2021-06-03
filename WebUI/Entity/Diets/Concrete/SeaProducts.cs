using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Entity.Diets.Concrete
{
    public class SeaProducts : Diet
    {
        private const string dietName = "Sea Products";
        private const string dietDescription = "Sea Products Açıklaması";

        public SeaProducts() : base(dietName, dietDescription)
        {

        }
    }
}