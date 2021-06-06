using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace WebUI.Report
{
    public class HtmlReportBuilder : ReportBuilderBase
    {
        public HtmlReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {

        }
        public override string BuildDietInfo()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
                    new DataColumn("Name", typeof(string)),
                    new DataColumn("Country",typeof(string)) });
            dt.Rows.Add(1, "John Hammond", "United States");
            dt.Rows.Add(2, "Mudassar Khan", "India");
            dt.Rows.Add(3, "Suzanne Mathews", "France");
            dt.Rows.Add(4, "Robert Schidner", "Russia");

            StringBuilder sb = new StringBuilder();
            //Table start.
            sb.Append("<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:Arial'>");

            //Adding HeaderRow.
            sb.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.ColumnName + "</th>");
            }
            sb.Append("</tr>");


            //Adding DataRow.
            foreach (DataRow row in dt.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    sb.Append("<td style='width:100px;border: 1px solid #ccc'>" + row[column.ColumnName].ToString() + "</td>");
                }
                sb.Append("</tr>");
            }

            //Table end.
            sb.Append("</table>");
            
            return sb.ToString();
        }

        public override string BuildPatientInfo()
        {
            return "";
        }
    }
}