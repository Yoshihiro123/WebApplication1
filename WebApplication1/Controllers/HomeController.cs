using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new UserModel());
        }

        /// <summary>
        /// 名前をpostされた時の処理
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index([Bind(Include = "Name")] UserModel user)
        {
            return RedirectToAction("Hello", user);
        }

        public ActionResult Hello([Bind(Include = "Name")] UserModel user)
        {
            if (string.IsNullOrEmpty(user.Name))
            {
                return RedirectToAction("Index");
            }
            return View(user);
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
    }
}