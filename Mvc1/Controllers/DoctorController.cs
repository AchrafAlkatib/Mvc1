using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Index(int temperature)
        {
            if

            
        }

    }
}
