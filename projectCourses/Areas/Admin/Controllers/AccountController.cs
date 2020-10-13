using projectCourses.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projectCourses.Services;

namespace projectCourses.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account/login
        public ActionResult login()
        {
            return View();
        }


        //post : Admin/Account/login
        [HttpPost]
        public ActionResult login(LoginAdmin logininfo) 
        {
            var Admin = new AdminService();

            var isloggedin = Admin.Login(logininfo.Email, logininfo.Passward);
            if (isloggedin)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                logininfo.message = "not success login";

                return View(logininfo);


            }

        }
    }
}