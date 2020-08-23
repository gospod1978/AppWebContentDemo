using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppWebController.Services
{
    public interface IPositionService
    {
        IEnumerable<SelectListItem> GetAll();
    }
}
