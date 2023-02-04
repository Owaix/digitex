using CoreSM.Interface;
using CoreSM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;

namespace CoreSM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            Dashboard dashboard = new Dashboard();
            var userid = Convert.ToInt16(HttpContext.Session.GetString("UserID"));
            if (userid == 1)
            {
                dashboard.ADVANCETAXPAID = _unitOfWork.Invoice.Find(x => x.TaxWithheld == "yes").Sum(x => x.TaxAmount).ToString("C");
                dashboard.WITHHOLDINGTAXPAID = _unitOfWork.Payment.GetAll().Sum(x => x.TaxAmount).ToString("C");
            }
            else
            {
                dashboard.ADVANCETAXPAID = _unitOfWork.Invoice.Find(x => x.TaxWithheld == "yes" && x.UserID == userid).Sum(x => x.TaxAmount).ToString("C");
                dashboard.WITHHOLDINGTAXPAID = _unitOfWork.Payment.Find(x => x.UserID == userid).Sum(x => x.TaxAmount).ToString("C");
            }

            return View(dashboard);
        }
        [HttpGet("Invoice")]
        public IActionResult Invoice()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            ViewData["saved"] = null;
            return View(new Invoice());
        }
        [HttpGet("Invoice/{id}")]
        public IActionResult Invoice(int id)
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            ViewData["saved"] = null;
            var obj = _unitOfWork.Invoice.Find(x => x.ID == id).FirstOrDefault();
            return View(obj);
        }

        [HttpPost("Invoice")]
        public IActionResult Invoice(Invoice invoice)
        {
            invoice.UserID = Convert.ToInt16(HttpContext.Session.GetString("UserID"));
            if (invoice.ID > 0)
            {
                _unitOfWork.Invoice.PutInvoice(invoice);
            }
            else
            {
                _unitOfWork.Invoice.AddInvoice(invoice);
            }

            ViewData["saved"] = "saved";
            return RedirectToAction("AdvanceTaxPaid", "Reports", null);
        }

        [HttpGet("Payment")]
        public IActionResult Payment()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            ViewData["saved"] = null;
            return View(new Payment());
        }
        [HttpGet("Payment/{id}")]
        public IActionResult Payment(int id)
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            ViewData["saved"] = null;
            var obj = _unitOfWork.Payment.Find(x => x.ID == id).FirstOrDefault();
            return View(obj);
        }

        [HttpPost("Payment")]
        public IActionResult Payment(Payment Payment)
        {
            Payment.UserID = Convert.ToInt16(HttpContext.Session.GetString("UserID"));
            if (Payment.ID > 0)
            {
                _unitOfWork.Payment.PutPayment(Payment);
            }
            else
            {
                _unitOfWork.Payment.AddPayment(Payment);
            }

            ViewData["saved"] = "saved";
            return RedirectToAction("WithholdingTaxPaid", "Reports", null);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login", null);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult TaxList()
        {
            if (HttpContext.Session.GetString("UserID") != "1")
            {
                return RedirectToAction("Index", "Home", null);
            }
            var obj = _unitOfWork.SalesCategory.GetAll();
            return View(obj);
        }

        [HttpGet("Addtax")]
        public IActionResult AddTax()
        {
            return View(new SalesCategory());
        }

        [HttpGet("Addtax/{id}")]
        public IActionResult AddTax(int id)
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            ViewData["saved"] = null;
            var obj = _unitOfWork.SalesCategory.Find(x => x.ID == id).FirstOrDefault();
            return View(obj);
        }

        [HttpPost("Addtax")]
        public IActionResult Addtax(SalesCategory salesCategory)
        {
            if (salesCategory.ID > 0)
            {
                _unitOfWork.SalesCategory.PutSalesCategory(salesCategory);
            }
            else
            {
                _unitOfWork.SalesCategory.Add(salesCategory);
            }
            return RedirectToAction("TaxList", "Home", null);
        }

        [HttpGet("Removetax/{id}")]
        public IActionResult Removetax(int id)
        {
            var obj = _unitOfWork.SalesCategory.Find(x => x.ID == id).FirstOrDefault();
            _unitOfWork.SalesCategory.Remove(obj);
            return RedirectToAction("TaxList", "Home", null);
        }

        [HttpGet("RemoveInvoice/{id}")]
        public IActionResult RemoveInvoice(int id)
        {
            var obj = _unitOfWork.Invoice.Find(x => x.ID == id).FirstOrDefault();
            _unitOfWork.Invoice.Remove(obj);
            return RedirectToAction("AdvanceTaxPaid", "Reports", null);
        }

        [HttpGet("RemovePayment/{id}")]
        public IActionResult RemovePayment(int id)
        {
            var obj = _unitOfWork.Payment.Find(x => x.ID == id).FirstOrDefault();
            _unitOfWork.Payment.Remove(obj);
            return RedirectToAction("WithholdingTaxPaid", "Reports", null);
        }

        public JsonResult GetCategory(string SaleTypeID, string PayerType)
        {
            var list = _unitOfWork.SalesCategory.GetSalesCategoryByType(SaleTypeID, PayerType);
            return Json(list);
        }

        public JsonResult GetTax(int SaleCategoryID)
        {
            var obj = _unitOfWork.SalesCategory.GetSalesTaxByCategory(SaleCategoryID);
            return Json(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}