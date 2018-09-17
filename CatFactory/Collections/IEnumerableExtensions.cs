using System.Collections.Generic;
using System.Text;

namespace CatFactory.Collections
{
    /// <summary>
    /// 
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns></returns>
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
