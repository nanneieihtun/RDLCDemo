using System;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using RdlcDemo.Models;

namespace RdlcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileResult DownloadPdf()
        {
            var downloadFileName = "CustomerReport" + DateTime.Now + ".pdf";
            var customers = new CustomerDao().GetCustomers();

            LocalReport localReport=new LocalReport();
            localReport.DataSources.Clear();
            localReport.DataSources.Add(new ReportDataSource("dsData", customers));
            localReport.ReportPath = Server.MapPath("~/Report/customer.rdlc");

            byte[] pdfBytes = localReport.Render("PDF");
            return File(pdfBytes, "application/pdf", downloadFileName);

        }
    }
}