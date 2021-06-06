using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Entity;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Report
{       
    public class ReportInfo
    {
        public PatientReport PatientReport { get; set; }
        public Diet DietReport { get; set; }
    }
}