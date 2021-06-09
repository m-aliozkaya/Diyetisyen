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
        private const string dietDescription = "Akdeniz diyeti kurallı bir diyet planı yerine yemek yemeyi temel alan bir beslenme planıdır. Akdeniz’e komşu ülkelerin geleneksel pişirme ve yemek yeme alışkanlıklarına dayanan bir beslenme şeklidir ve adını da buradan almaktadır. Akdeniz diyeti dünya genelinde Med Diyeti olarak da bilinmektedir. İlk olarak 1993 yılında Harvard Halk Sağlığı ve Dünya Sağlık Örgütü’nün işbirliği ile Akdeniz Diyeti Piramidi oluşturulmuştur. Daha sonra ki yıllarda da Akdeniz diyetinin popülerliği giderek artmıştır.";
        private const string image = "akdenizsalatası.jpg";
        public Mediterranean() : base(dietName, dietDescription,id,image)
        {

        }
    }
}