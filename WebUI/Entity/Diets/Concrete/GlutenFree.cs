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
        private const string dietDescription = "Gluteni tamamen hayatınızdan çıkarmak sandığınız kadar zor değil. Ancak bunun için sağlıklı ve düzenli bir beslenme planı oluşturmanız gerekiyor. Vitamin ve minerallerce zengin, bol lifli, doğal, besleyici sebze ve meyveler; bitkisel protein kaynakları olan kuru baklagiller; tavuk, balık ve et çeşitleri; yumurta, peynir, süt ve yoğurt gibi besleyici hayvansal gıdalar, glutensiz beslenme modelinizin yapı taşlarını oluşturmalı.";
        private const string image = "glutenfree.jpg";
        public GlutenFree() : base(dietName, dietDescription,id,image)
        {

        }
    }
}