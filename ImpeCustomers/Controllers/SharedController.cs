﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImpeCustomers.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult SearchResult()
        {
            return View();
        }
    }
}