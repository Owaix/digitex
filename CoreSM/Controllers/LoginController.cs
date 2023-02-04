using CoreSM.Interface;
using CoreSM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreSM.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public LoginController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            //var popularDevelopers = _unitOfWork.Users.GetUsersByUserAndPass("admin", "admin");
            //if (popularDevelopers != null)
            //{
            //    HttpContext.Session.SetString("UserID", popularDevelopers.UserID.ToString());
            //    HttpContext.Session.SetString("Username", popularDevelopers.UserName);
            //    return RedirectToAction("Index", "Home", null);
            //}
            return View(new Users());
        }

        [HttpPost]
        public IActionResult Index(Users login)
        {

            var popularDevelopers = _unitOfWork.Users.GetUsersByUserAndPass(login.UserName, login.Password);
            if (popularDevelopers != null)
            {
                HttpContext.Session.SetString("UserID", popularDevelopers.UserID.ToString());
                HttpContext.Session.SetString("Username", popularDevelopers.UserName);
                return RedirectToAction("Index", "Home", null);
            }
            return View(login);
        }

        [HttpGet("UserList")]
        public IActionResult UserList()
        {
            if (HttpContext.Session.GetString("UserID") != "1")
            {
                return RedirectToAction("Index", "Home", null);
            }
            var obj = _unitOfWork.Users.GetAll();
            return View(obj);
        }

        [HttpGet("AddUser")]
        public IActionResult AddUser()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            return View(new Users { });
        }

        [HttpGet("AddUser/{id}")]
        public IActionResult AddUser(int id)
        {
            var obj = _unitOfWork.Users.Find(x => x.UserID == id).FirstOrDefault();
            return View(obj);
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(Users login)
        {
            if (login.UserID > 0)
            {
                _unitOfWork.Users.PutUsers(login);
            }
            else
            {
                _unitOfWork.Users.AddUsers(login);
            }
            return RedirectToAction("UserList", "Login", null);
        }

        [HttpGet("RemoveUser/{id}")]
        public IActionResult RemoveUser(int id)
        {
            var obj = _unitOfWork.Users.Find(x => x.UserID == id).FirstOrDefault();
            _unitOfWork.Users.Remove(obj);
            return RedirectToAction("UserList", "Login", null);
        }
    }
}