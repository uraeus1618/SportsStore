﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
		private DataContext context;

		public HomeController(DataContext ctx)
		{
			context = ctx;
		}
        public IActionResult Index()
        {
			ViewBag.Message = "Sports Store App";
			return View(context.Products.OrderBy(p => p.ProductId).First());
		}

        public IActionResult About()
        {
            return View();
        }

      
    }
}
