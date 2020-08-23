using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppWebController.Services
{
    public class PositionService : IPositionService
    {
        IEnumerable<SelectListItem> IPositionService.GetAll()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "JuniroDeveloper" },
                new SelectListItem { Value = "2", Text = "RegularDeveloper" },
                new SelectListItem { Value = "3", Text = "SeniorDeveloper" },
                new SelectListItem { Value = "4", Text = "JuniorQa" },
            };
        }
    }
}
