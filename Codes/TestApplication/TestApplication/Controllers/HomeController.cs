using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Services;

namespace TestApplication.Controllers
{
    public class HomeController: Controller
    {
        public HomeController(IClock clock)
        {

        }
    }
}
