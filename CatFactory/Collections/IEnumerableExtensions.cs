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
            var output = new StringBuilder();

            foreach (var item in enumerable)
            {
                output.AppendLine(item);
            }

            return output;
        }
    }
}
