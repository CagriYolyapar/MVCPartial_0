﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPartial_0.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult ListCategories()
        {
            return View();
        }
    }
}