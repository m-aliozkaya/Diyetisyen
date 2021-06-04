using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Report
{
    public abstract class ReportBuilderBase
    {
        protected ReportInfo Info;

        public ReportBuilderBase (ReportInfo reportInfo)
        {
            Info = reportInfo;
        }

        public abstract string BuildPatientInfo();
        public abstract string BuildDietInfo();

        public string BuildOutput()
        {
            string output = "";
            output += BuildPatientInfo();
            output += BuildDietInfo();

            return output;
        }
       
    }


  
}