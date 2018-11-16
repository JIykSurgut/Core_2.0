﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        DataBaseContext db;
        public HomeController(DataBaseContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Article.ToList());
        }
    }
}