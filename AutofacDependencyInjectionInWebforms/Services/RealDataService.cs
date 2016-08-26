using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacDependencyInjectionInWebforms.Services
{
    public class RealDataService : ISomeDataService
    {
        public IEnumerable<string> GetSomeData()
        {
            return new[] {
                "This is the item 1 returned from real service"
            };
        }
    }
}