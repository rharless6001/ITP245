﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITP245.Areas.School.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School/School
        public ActionResult Index()
        {
            return View();
        }
    }
}