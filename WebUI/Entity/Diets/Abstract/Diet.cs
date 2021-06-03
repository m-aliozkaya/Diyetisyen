using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Entity.Diets.Abstract
{
    public abstract class Diet
    {
        public string Name { get;}
        public string Description { get;}

        public Diet(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}