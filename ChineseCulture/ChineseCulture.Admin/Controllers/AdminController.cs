﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChineseCulture.Admin.Controllers
{
    public class AdminController : FunctionController
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}