﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticeCore.Controllers
{
    public class Profile1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}