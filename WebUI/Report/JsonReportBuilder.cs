using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Report
{
    public class JsonReportBuilder : ReportBuilderBase
    {
        public JsonReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {

        }

        public override string BuildDietInfo()
        {
            throw new NotImplementedException();
        }

        public override string BuildPatientInfo()
        {
            throw new NotImplementedException();
        }
    }
}