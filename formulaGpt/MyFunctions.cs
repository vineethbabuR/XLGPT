using ExcelDna.Integration;

namespace formulaGpt
{
    public static class MyFunctions
    {
        [ExcelFunction(Description = "My first .NET Function")]
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }
    }
}