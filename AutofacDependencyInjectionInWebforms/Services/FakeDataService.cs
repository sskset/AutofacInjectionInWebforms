using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacDependencyInjectionInWebforms.Services
{
    public class FakeDataService : ISomeDataService
    {
        public IEnumerable<string> GetSomeData()
        {
            return new[] {
                "Michael Jordan",
                "Kobe Bryant",
                "Allen Iverson"
            };
        }
    }
}