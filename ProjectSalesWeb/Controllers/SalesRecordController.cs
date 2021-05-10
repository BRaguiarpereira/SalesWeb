using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSalesWeb.Controllers
{
    public class SalesRecordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimplesSearch()
        {
            return View();
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
