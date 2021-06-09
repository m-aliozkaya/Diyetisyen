using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Entity.Diets.Abstract
{
    public abstract class Diet
    {
        [JsonProperty("DiyetId")]
        public int Id { get; }
        [JsonProperty("DiyetAdi")]
        public string Name { get;}
        [JsonProperty("DiyetAciklamasi")]
        public string Description { get;}
        [JsonIgnore]
        public string Image { get;}
        public Diet(string name, string description, int id,string image)
        {
            Name = name;
            Description = description;
            Id = id;
            Image = image;
        }

    }
}