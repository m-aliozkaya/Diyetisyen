using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Entity.Diseases.Abstract
{
    public abstract class Disease
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        public Disease(string name, string description, int id)
        {
            Name = name;
            Description = description;
            Id = id;
        }
    }
}
