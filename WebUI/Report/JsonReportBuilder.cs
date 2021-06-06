using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return JsonConvert.SerializeObject(_reportInfo.DietReport, Formatting.Indented);
        }

        public override string BuildPatientInfo()
        {

            return JsonConvert.SerializeObject(_reportInfo.PatientReport, Formatting.Indented);
        }

        public override string BuildOutput()
        {
            JToken patientJson = JObject.Parse(BuildPatientInfo());
            JToken dietJson = JObject.Parse(BuildDietInfo());

            JObject result = new JObject();
            result.Add("HastaBilgisi", patientJson);
            result.Add("DiyetBilgisi", dietJson);

            return result.ToString();
        }

        public override string BuildUpsideDown()
        {
            JToken patientJson = JObject.Parse(BuildPatientInfo());
            JToken dietJson = JObject.Parse(BuildDietInfo());

            JObject result = new JObject();
            result.Add("DietInfo", dietJson);
            result.Add("PatientInfo", patientJson);

            return result.ToString();
        }
    }
}