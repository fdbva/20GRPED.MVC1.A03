using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20GRPED.MVC1.A03.MvcStrings.Models;
using _20GRPED.MVC1.A03.MvcStrings.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20GRPED.MVC1.A03.MvcStrings.Controllers
{
    public class StringComparisonController : Controller
    {
        private readonly StringComparisonService _stringComparisonService;

        public StringComparisonController(
            StringComparisonService stringComparisonService)
        {
            _stringComparisonService = stringComparisonService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Compare(
            StringComparisonModel stringComparisonModel)
        {
            ViewBag.Title = "Compare";

            var result = _stringComparisonService.Compare(stringComparisonModel);
            stringComparisonModel.Result = result;
            
            return View("Result", stringComparisonModel);
        }

        [HttpPost]
        public IActionResult CompareIgnoreCase(
            StringComparisonModel stringComparisonModel)
        {
            ViewBag.Title = "CompareIgnoreCase";

            var result = _stringComparisonService.CompareIgnoreCase(stringComparisonModel);
            stringComparisonModel.Result = result;

            return View("Result", stringComparisonModel);
        }
    }
}