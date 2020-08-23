using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AppWebController.Filters.ModelBinders;
using AppWebController.Services;
using AppWebController.ValidateAttributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

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
            //[Required]
            public string FirstName { get; set; }

            public string LastName { get; set; }
        }

        public class TestInputModel : IValidatableObject
        {
            //[Range(2000, 3000)]
            //moga da iziskam stoinosti ako li ne error
            [BindNever]
            public int Id { get; set; }

            //[Required]
            public Names Names { get; set; }

            [Required]
            [MinLength(3)]
            public string University { get; set; }

            [EmailAddress]
            [Required]
            public string Email { get; set; }

            //[StringLength(10, MinimumLength = 10)]
            [Required]
            [EgnValidation]
            //[RegularExpression("[0-9]{10}", ErrorMessage ="Kofti EGN")]
            public string Egn { get; set; }

            public DateTime DateOfBirth { get; set; }

            [Display(Name = "Years of exeprience")]
            public int YearsOfExperience { get; set; }

            public int CandidateType { get; set; }

            public IEnumerable<SelectListItem> AllTypes { get; set; }

            //tova e za fila IEnumerable<IFormFile> ako isam mnogo 
            public IFormFile CV { get; set; }

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                if(int.Parse(this.Egn.Substring(0, 2))
                    != this.DateOfBirth.Year % 100)
                {
                    yield return new ValidationResult
                        ("Godinata na rajdane i EGN ne sa validna combinacia");
                }
            }

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
                Email = "@softuni.bg",
                Egn = "7808107580",
                YearsOfExperience = 1,
                AllTypes = positionService.GetAll(),
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(TestInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.AllTypes = positionService.GetAll();
                return this.View(input);
            }

            using(var fileStream = new FileStream("user.doc", FileMode.Create))
            {
                await input.CV.CopyToAsync(fileStream);
            }

            //return this.Json(input); sled kato imame fail
            return this.Redirect("/");
        }
    }
}
