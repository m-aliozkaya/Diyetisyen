using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Entity.Diets.Abstract
{
    public abstract class Diet
    {
        public int Id { get; }
        public string Name { get;}
        public string Description { get;}

        public Diet(string name, string description,int id)
        {
            Name = name;
            Description = description;
            Id = id;
        }

    }
}