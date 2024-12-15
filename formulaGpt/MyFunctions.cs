using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;

namespace formulaGpt
{
    public static class MyFunctions
    {
        [ExcelFunction(Description ="My first .NET Function")]
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        
    }


}
