﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankBotNav.Controllers
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

        public ActionResult BankBot()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Palfinger()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult HelpGv()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Oebb()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Post()
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