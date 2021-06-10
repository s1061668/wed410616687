using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410616687.ViewModels;

namespace Web410616687.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Signup()
        {
            return View(new SignUpData());
        }
        [HttpPost]
        public ActionResult Signup(SignUpData data)
        {
            if (ModelState.IsValid) 
            {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}