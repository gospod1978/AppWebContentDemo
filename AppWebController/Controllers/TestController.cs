using System;
using System.ComponentModel.DataAnnotations;
using AppWebController.Filters.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AppWebController.Controllers
{
    public class TestController : Controller
    {
        public class Names
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class TestInputModel
    {
        //moga da iziskam stoinosti ako li ne error
        //[Range(2000, 3000)]
        [BindNever]
        public int Id { get; set; }

        public Names Names { get; set; }

        //maham go zashtoto sam go registriral globalno YMBProvider
        //[ModelBinder(typeof(YearModelBinder))]
        public int Year { get; set; }

        public int[] Years { get; set; }
    }


        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Index(TestInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Json(this.ModelState);
            }
            return this.Json(input);
        }
    }
}
