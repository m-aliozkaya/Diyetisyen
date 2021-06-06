using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Report
{
    public abstract class ReportBuilderBase
    {
        protected ReportInfo _reportInfo;

        public ReportBuilderBase (ReportInfo reportInfo)
        {
            _reportInfo = reportInfo;
        }

        public abstract string BuildPatientInfo();
        public abstract string BuildDietInfo();

        public virtual string BuildOutput()
        {
            string output = "";
            output += BuildPatientInfo();
            output += BuildDietInfo();

            return output;
        }

        public virtual string BuildUpsideDown()
        {
            string output = "";
            output += BuildDietInfo();
            output += BuildPatientInfo();

            return output;
        }
    }


  
}