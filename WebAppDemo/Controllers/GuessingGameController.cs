﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
