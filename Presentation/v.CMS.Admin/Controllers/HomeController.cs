﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace v.CMS.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}