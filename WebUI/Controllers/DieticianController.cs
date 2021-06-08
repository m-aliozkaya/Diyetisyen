using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Data;
using WebUI.Entity;
using WebUI.Entity.Diets.Abstract;
using WebUI.Entity.Diseases.Abstract;
using WebUI.Models;
using WebUI.Report;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class DieticianController : Controller
    {
        // GET: Dietician
        public ActionResult Index()
        {

            if (Session["role"] != null)
            {
                Claims role = (Claims)Session["Role"];

                if (role != Claims.Dietician)
                {
                    return RedirectToAction("Login", "Account", new {ReturnUrl = Request.Path });
                }

            }
            else
            {
                return RedirectToAction("Login", "Account", new { ReturnUrl = Request.Path });
            }

            List<Patient> patientList = InMemory.Memory.GetByDieticianUserNamePatients(Session["userName"].ToString());
            return View(patientList);
        }

        public ActionResult AddPatient()
        {
            ViewBag.DietId = new SelectList(InMemory.Memory.GetDiets(), "Id", "Name");
            ViewBag.DiseaseId = new SelectList(InMemory.Memory.GetDiseases(), "Id", "Name");
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddPatient(PatientDietModel model)
        {
            string userName = Session["userName"].ToString();

            Disease disease = InMemory.Memory.GetDiseases().Where(d => d.Id == model.DiseaseId).SingleOrDefault();
            Diet diet = InMemory.Memory.GetDiets().Where(d => d.Id == model.DietId).SingleOrDefault();
            Dietician dietician = InMemory.Memory.GetDieticians().Where(d => d.UserName == userName).SingleOrDefault();

            Patient patient = new Patient
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                TcNo = model.TcNo,
                Disease = disease,
                Diet = diet,
                Dietician = dietician
            };

            if (ModelState.IsValid)
            {
                InMemory.Memory.AddPatient(patient);

                return RedirectToAction("/");
            }
            return View();
        }

        public ActionResult GetPatientReport(int id)
        {

            ViewBag.PatientId = id;
            return View();
        }       
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult GetPatientReport(int id, string submit)
        {
            Patient patient = InMemory.Memory.GetPatients().Where(p => p.Id == id).SingleOrDefault();
            PatientReport patientReport = new PatientReport()
            {
                PatientName = patient.FirstName + " " + patient.LastName,
                TcNo = patient.TcNo,
                DiseaseName = patient.Disease.Name,
                DieticianTcNo = patient.Dietician.TcNo,
                DieaticianName = patient.Dietician.FirstName + " " + patient.Dietician.LastName
            };

            ReportInfo reportInfo = new ReportInfo()
            {
                DietReport = patient.Diet,
                PatientReport = patientReport
            };

            ReportManager reportManager;

            switch (submit)
            {
                case "HTML Rapor Al":
                    reportManager = new ReportManager(new HtmlReportBuilder(reportInfo));
                    break;
                case "JSON Rapor Al":
                    reportManager = new ReportManager(new JsonReportBuilder(reportInfo));
                    break;
                default:
                    reportManager = new ReportManager(new HtmlReportBuilder(reportInfo));
                    break;
            }

            ViewBag.PatientId = id;
            ViewBag.result = reportManager.Build();
            return View();
        }

        public ActionResult ChangePatientDiet(int id)
        {
            Patient patient = InMemory.Memory.GetPatients().Where(p => p.Id == id).FirstOrDefault();
            ChangeDietModel model = new ChangeDietModel()
            {
                PatientId = patient.Id,
                DietId = patient.Diet.Id,
                DiseaseName = patient.Disease.Name,
                PatientName = patient.FirstName + " " + patient.LastName
            };
            ViewBag.DietId = new SelectList(InMemory.Memory.GetDiets(), "Id", "Name", model.DietId);
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult ChangePatientDiet(ChangeDietModel model)
        {
            if (ModelState.IsValid)
            {
                Diet diet = InMemory.Memory.GetDiets().Where(d => d.Id == model.DietId).FirstOrDefault();
                Patient patient = InMemory.Memory.GetPatients().Where(p => p.Id == model.PatientId).FirstOrDefault();
                patient.Diet = diet;
                return RedirectToAction("Index");
            }

            ViewBag.DietId = new SelectList(InMemory.Memory.GetDiets(), "Id", "Name", model.DietId);
            return View(model);
        }

    }
}