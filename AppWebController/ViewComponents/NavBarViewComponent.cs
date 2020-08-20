using System;
using AppWebController.Services;
using AppWebController.ViewModels.NavBar;
using Microsoft.AspNetCore.Mvc;

namespace AppWebController.ViewComponents
{
    //moga i da sloja viewcomponent no moga i da ne go sloja
    //[ViewComponent(Name = "NavBar")]
    public class NavBarViewComponent : ViewComponent
    {
        private readonly IYearsService yearsService;

        public NavBarViewComponent(IYearsService yearsService)
        {
            this.yearsService = yearsService;
        }

        public IViewComponentResult Invoke(int count)
        {
            // ako mahna int count, moga direktno da podam godini
            var viewModel = new NavBarViewModel();
            viewModel.Years = this.yearsService.GetLastYears(count);
            return this.View(viewModel);
        }
    }
}
