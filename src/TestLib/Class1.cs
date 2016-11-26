using System.Linq;

namespace TestLib
{
    public class Class1
    {
        public Class1()
        {
            var str = "hallo this 1 should be filterable";
            var someOthBool = str.Any(c => c == '1');
        }
    }
}
