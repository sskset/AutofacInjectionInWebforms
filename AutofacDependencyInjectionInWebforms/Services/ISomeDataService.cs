using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDependencyInjectionInWebforms.Services
{
    public interface ISomeDataService
    {
        IEnumerable<string> GetSomeData();
    }
}
