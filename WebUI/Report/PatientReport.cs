using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace WebUI.Report
{
    public class PatientReport
    {
        [JsonProperty("HastaTcNo")]
        public string TcNo { get; set; }
        [JsonProperty("HastaAdi")]
        public string PatientName { get; set; }
        [JsonProperty("DiyetisyenTcNo")]
        public string DieticianTcNo { get; set; }
        [JsonProperty("DiyetisyenAdi")]
        public string DieaticianName { get; set; }
        [JsonProperty("HastalikAdi")]
        public string DiseaseName { get; set; }
    }
}