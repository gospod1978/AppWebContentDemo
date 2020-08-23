using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AppWebController.Filters.ModelBinders;
using AppWebController.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppWebController.Controllers
{
    public class TestController : Controller
    {
        private readonly IPositionService positionService;

        public TestController(IPositionService positionService)
        {
            this.positionService = positionService;
        }

        public class Names
        {
            [Required]
            public string FirstName { get; set; }

            public string LastName { get; set; }
        }

        public class TestInputModel
        {
            //[Range(2000, 3000)]
            //moga da iziskam stoinosti ako li ne error
            [BindNever]
            public int Id { get; set; }

            [Required]
            public Names Names { get; set; }

            [Required]
            [MinLength(3)]
            public string University { get; set; }

            [EmailAddress]
            [Required]
            public string Email { get; set; }

            [StringLength(10, MinimumLength = 10)]
            [Required]
            [RegularExpression("[0-9]{10}", ErrorMessage ="Kofti EGN")]
            public string Egn { get; set; }

            public DateTime DateOfBirth { get; set; }

            [Display(Name = "Years of exeprience")]
            public int YearsOfExperience { get; set; }

            public int CandidateType { get; set; }

            public IEnumerable<SelectListItem> AllTypes { get; set; }

            // tova go izpolzvam kato izpolzvam enum no maham gornoto
            //public CandidateType CandidateType { get; set; }

            //maham go zashtoto sam go registriral globalno YMBProvider
            //[ModelBinder(typeof(YearModelBinder))]
            //public int Year { get; set; }

            //public int[] Years { get; set; }
        }

        public enum CandidateType
        {
            JuniroDeveloper = 1,
            RegularDeveloper = 2,
            SeniorDeveloper = 3,
            JuniorQa =4,
        }

        public IActionResult Index()
        {
            var model = new TestInputModel
            {
                University = "SoftUni",
                //Email = "@softuni.bg",
                //Egn = "0000000000",
                //YearsOfExperience = 1,
                AllTypes = positionService.GetAll(),
            };

            return this.View(model);
        }

        [HttpPost]
        public IActionResult Index(TestInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.AllTypes = positionService.GetAll();
                return this.View(input);
            }
            return this.Json(input);
        }
    }
}
