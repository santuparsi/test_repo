using HandOnModelValidations.Models;
using HandOnModelValidations.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandOnModelValidations.Controllers
{
    public class UserController : Controller
    {
        private UserRepository _userRepository;
        public UserController()
        {
            _userRepository = new UserRepository();
        }
        // GET: User
        public ActionResult Index() //Get All the Use
        {
            var users=_userRepository.GetAll();
            return View(users);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.Register(user);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        [HttpGet]
        public ActionResult Validate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validate(Login login)
        {
            if (ModelState.IsValid)
            {
                var user = _userRepository.Validate(login);
                if (user != null)
                {
                    return RedirectToAction("UserDashboard");
                }
                else
                {
                    ViewBag.ErrMsg = "Invalid Credentials";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}