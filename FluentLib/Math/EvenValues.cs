using System.Collections.Generic;
using System.Linq;

namespace FluentLib.Math
{
    public class EvenValues
    {
        public EvenValues()
        {

        }

        public List<int> OutOf(IEnumerable<int> values)
        {
            return values.Where(value => value % 2 == 0).ToList();
        }
    }
}