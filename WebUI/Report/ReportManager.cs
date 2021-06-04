using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Report
{
    public class ReportManager
    {
        private ReportBuilderBase _reportBuilderBase;

        public ReportManager(ReportBuilderBase reportBuilderBase)
        {
            _reportBuilderBase = reportBuilderBase;

        }

        public string Build()
        {
            return _reportBuilderBase.BuildOutput();
            
        }
        public string BuildUpsideDown()
        {
            string output = "";
            output += _reportBuilderBase.BuildDietInfo();
            output += _reportBuilderBase.BuildPatientInfo();
            return output;

        }
    }
}