﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20GRPED.MVC1.A03.MvcStrings.Models;
using Microsoft.AspNetCore.Mvc;

namespace _20GRPED.MVC1.A03.MvcStrings.Controllers
{
    public class StringComparisonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Compare(StringComparisonModel stringComparisonModel)
        {
            ViewBag.Title = "Compare";
            var result = stringComparisonModel.Left == stringComparisonModel.Right;

            stringComparisonModel.Result = result;
            
            return View("Result", stringComparisonModel);
        }

        public IActionResult CompareIgnoreCase(StringComparisonModel stringComparisonModel)
        {
            ViewBag.Title = "CompareIgnoreCase";
            var result =
                string.Equals(stringComparisonModel.Left, stringComparisonModel.Right, StringComparison.OrdinalIgnoreCase);

            stringComparisonModel.Result = result;

            return View("Result", stringComparisonModel);
        }
    }
}