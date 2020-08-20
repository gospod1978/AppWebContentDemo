using System.Collections.Generic;

namespace AppWebController.Services
{
    public interface IYearsService
    {
        IEnumerable<int> GetLastYears(int count);
    }
}
