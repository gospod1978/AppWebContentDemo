using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppWebController.ViewModels;
using Microsoft.Extensions.Configuration;
using AppWebController.ViewModels.Home;
using AppWebController.Services;

namespace AppWebController.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
            
        }

        public IActionResult Index()
        {
            //ne ok da izpolzvame ViewData and ViewBag
            this.ViewData["name"] = "Niki";
            this.ViewBag.Family = "Stoyan";
            var viewModel = new IndexViewModel
            {
                Year = DateTime.UtcNow.Year,
                Message = this.configuration["YouTube:ApiKey"],
                Names = new List<string> { "niki", "stoyqn"},
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            return this.Content(this.configuration["YouTube:ApiKey"]);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
