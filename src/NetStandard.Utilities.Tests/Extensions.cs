using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NetStandard.Utilities.Tests
{
    public static class Extensions
    {
        public static IEnumerable<object> ToGenericEnumerable(this IEnumerable enumerable)
        {
            return enumerable.Cast<object>();
        }
    }
}