using System.Linq;

namespace TestLib
{
    public class Working
    {
        public Working()
        {
            var str = "hallo this 1 should be filterable";
            var someOthBool = str.Any(c => c == '1');
        }
    }
}
