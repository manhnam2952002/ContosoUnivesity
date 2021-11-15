using Contoso_Univesity.Data;
using Contoso_Univesity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso_Univesity.Controllers
{
    public class HomeController : Controller
    {
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;
            private readonly SchoolContext _context;

            public HomeController(ILogger<HomeController> logger, SchoolContext context)
            {
                _logger = logger;
                _context = context;
            }
        }
}
