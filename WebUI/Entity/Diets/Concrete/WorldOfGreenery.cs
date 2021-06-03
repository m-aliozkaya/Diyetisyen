using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Entity.Diets.Concrete
{
    public class WorldOfGreenery: Diet
    {
        private const string dietName = "World Of Greenery";
        private const string dietDescription = "World Of Greenery Açıklaması";

        public WorldOfGreenery() : base(dietName, dietDescription)
        {

        }
    }
}