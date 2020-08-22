using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AppWebController.Filters.ModelBinders
{
    public class YearModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var stringDateFromRequest =
                bindingContext.ValueProvider.GetValue("date").FirstOrDefault();

            if (stringDateFromRequest == null)
            {
                bindingContext.Result = ModelBindingResult.Failed();
            }
            else
            {
                var date = DateTime.Parse(stringDateFromRequest);

                bindingContext.Result = ModelBindingResult.Success(date.Year);
            }

            return Task.CompletedTask;
        }
    }
}
