﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kalakaar.Controllers
{
    public class PartnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
