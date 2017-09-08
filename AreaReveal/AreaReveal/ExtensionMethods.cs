using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaReveal
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> ToIEnumarable<T>(this T item)
        {
            yield return item;
        }
    }
}
