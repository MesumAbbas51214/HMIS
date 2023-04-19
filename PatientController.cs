using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistration.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
