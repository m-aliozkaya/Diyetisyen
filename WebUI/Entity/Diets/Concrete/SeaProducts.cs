using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Entity.Diets.Concrete
{
    public class SeaProducts : Diet
    {
        private const int id = 3;
        private const string dietName = "Deniz Ürünleri";
        private const string dietDescription = "Deniz Ürünleri Salatasının 100 gramında 272 kcal kalori, yani 200 gram Deniz Ürünleri Salatasında 544 kalori bulunmaktadır.";
        private const string image = "denizürünleri.jpg";
        public SeaProducts() : base(dietName, dietDescription,id,image)
        {

        }
    }
}