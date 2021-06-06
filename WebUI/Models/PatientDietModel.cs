using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PatientDietModel
    {
        public int Id { get; set; }
        [DisplayName("Adı")]
        public string FirstName { get; set; }
        [DisplayName("Soyadı")]
        public string LastName { get; set; }
        [DisplayName("TC Kimlik Numarası")]
        public string TcNo { get; set; }
        [DisplayName("Diyet")]
        public int DietId { get; set; }
        [DisplayName("Hastalık")]
        public int DiseaseId { get; set; }

    }
}