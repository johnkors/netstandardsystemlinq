using System.Linq;

namespace TestLibNotWorking
{
    public class NotWorking
    {
        public NotWorking()
        {
            var str = "hallo this 1 should be filterable";
            var someOthBool = str.Any(c => c == '1');
        }
    }
}
