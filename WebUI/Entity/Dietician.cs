using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebUI.Entity
{
    public class Dietician:IUser
    {
        public int Id { get; set; }

        [DisplayName("Adı")]
        public string FirstName { get; set; }

        [DisplayName("Soyadı")]
        public string LastName { get; set; }

        [DisplayName("TC Kimlik Numarası")]
        public string TcNo { get; set; }

        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [DisplayName("Şehir")]
        public string City { get; set; }

        [DisplayName("Resim")]
        public string Image { get; set; }

        [DisplayName("Hastane")]
        public string HospitalName { get; set; }

        [DisplayName("Tecrübe")]
        public int Experience { get; set; }

        [DisplayName("Üniversite Adı")]
        public string UniversityName { get; set; }
    }
}