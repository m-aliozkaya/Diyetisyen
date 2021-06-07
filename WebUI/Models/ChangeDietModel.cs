using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Models
{
    public class ChangeDietModel
    {
        public int PatientId { get; set; }
        [DisplayName("Hastanın Adı")]
        public string PatientName { get; set; }
        [DisplayName("Hastalığın Adı")]
        public string DiseaseName { get; set; }
        [DisplayName("Diyet")]
        public int DietId { get; set; }
    }
}