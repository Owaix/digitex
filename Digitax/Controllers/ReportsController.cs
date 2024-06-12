using CoreSM.Interface;
using CoreSM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CoreSM.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult WithholdingTaxPaid()
        {
            IEnumerable<Payment> list;
            if (HttpContext.Session.GetString("UserID") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            var userID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            if (userID == 1)
            {
                list = _unitOfWork.Payment.GetAll();
            }
            else
            {
                list = _unitOfWork.Payment.Find(x => x.UserID == userID);
            }
            return View(list);
        }

        [HttpGet]
        public JsonResult CreateChalan(int id)
        {
            var obj = _unitOfWork.Payment.GetById(id);
            obj.isCreated = false;
            _unitOfWork.Payment.PutPayment(obj);
            return Json("the challan is in processing , please contact administrator");
        }

        public IActionResult AdvanceTaxPaid()
        {
            IEnumerable<Invoice> list;
            if (HttpContext.Session.GetString("UserID") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            var userID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            if (userID == 1)
            {
                list = _unitOfWork.Invoice.GetInvoice();
            }
            else
            {
                list = _unitOfWork.Invoice.Find(x => x.UserID == userID);
            }
            return View(list);
        }
    }
}