﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntradaDeDados.Controllers
{
    public class DadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
