﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationFinal.Controllers
{
    public class DonorController : Controller
    {
        //
        // GET: /Donor/

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
        public ActionResult Index()
        {
            return View();
    }
    }
}
