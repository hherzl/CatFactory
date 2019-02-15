using System.Collections.Generic;
using System.Text;

namespace CatFactory.Collections
{
    /// <summary>
    /// Provides extension methods for IEnumerable interface
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Gets an instance of <see cref="StringBuilder"/> that contains all content from string collection
        /// </summary>
        /// <param name="collection">Collection of <see cref="string"/></param>
        /// <returns>An instance of <see cref="StringBuilder"/> that contains all strings from enumerator</returns>
        public static StringBuilder ToStringBuilder(this IEnumerable<string> collection)
        {
            var output = new StringBuilder();

            foreach (var item in collection)
            {
                output.AppendLine(item);
            }

            return output;
        }
    }
}
