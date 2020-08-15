using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthorizeFilter.Models;
using System.Web.Security;

namespace AuthorizeFilter.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Membership user)
       {
           using(UserDbContext db=new UserDbContext())
            {
                bool isvalid = db.Users.Any(x => x.Username == user.Username && x.Password == user.Password);
                if (isvalid)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("Index","Home");
                }
                ModelState.AddModelError("", "invlid username and password");
            }
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
        {
            using(UserDbContext db=new UserDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
           return RedirectToAction("Login");

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}