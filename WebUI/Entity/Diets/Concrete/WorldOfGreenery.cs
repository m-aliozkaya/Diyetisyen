using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Entity.Diets.Concrete
{
    public class WorldOfGreenery: Diet
    {
        private const int id = 4;
        private const string dietName = "Yeşillikler Dünyası";
        private const string dietDescription = "Sağlıklı beslenmede ya da diyet programınızda listenize ekleyeceğiniz yeşillikler ile hem ödemlerden kurtulabilirsiniz, hem de sindirim sisteminizi rahatlatabilirsiniz.";
        private const string image = "yeşilliklerdünyası.jpg";
        public WorldOfGreenery() : base(dietName, dietDescription,id,image)
        {

        }
    }
}