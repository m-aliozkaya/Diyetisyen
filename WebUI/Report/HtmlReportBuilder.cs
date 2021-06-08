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
        public override string BuildPatientInfo()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("TcNo", typeof(string)),
                    new DataColumn("Hasta Adı", typeof(string)),
                    new DataColumn("Diyetisyen TcNo",typeof(string)),
                    new DataColumn("Diyetisyen Adı",typeof(string)),
                    new DataColumn("Hastalık Adı",typeof(string)),
            });

            dt.Rows.Add(_reportInfo.PatientReport.TcNo
                , _reportInfo.PatientReport.PatientName
                , _reportInfo.PatientReport.DieticianTcNo
                , _reportInfo.PatientReport.DiseaseName
                , _reportInfo.PatientReport.DiseaseName
                );

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

        public override string BuildDietInfo()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Diyet Id", typeof(string)),
                    new DataColumn("Diyet Adı", typeof(string)),
                    new DataColumn("Diyet Açıklaması",typeof(string))
            });

            dt.Rows.Add(_reportInfo.DietReport.Id
                , _reportInfo.DietReport.Name
                , _reportInfo.DietReport.Description
                );

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

        public override string BuildOutput()
        {
            string result = "";
            result += BuildPatientInfo();
            result += "</br>";
            result += BuildDietInfo();

            return result;
        }

        public override string BuildUpsideDown()
        {
            string result = "";
            result += BuildDietInfo();
            result += "</br>";
            result += BuildPatientInfo();

            return result;
        }
    }
}