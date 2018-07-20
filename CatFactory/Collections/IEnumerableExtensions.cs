using System.Collections.Generic;
using System.Text;

namespace CatFactory.Collections
{
    public static class IEnumerableExtensions
    {
        public static StringBuilder ToStringBuilder(this IEnumerable<string> enumerable)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in enumerable)
            {
                stringBuilder.AppendLine(item);
            }

            return stringBuilder;
        }
    }
}
