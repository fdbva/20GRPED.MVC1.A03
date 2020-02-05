using System;
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
            var result = stringComparisonModel.Left == stringComparisonModel.Right;

            stringComparisonModel.Result = result;
            
            return View("Result", stringComparisonModel);
        }
    }
}