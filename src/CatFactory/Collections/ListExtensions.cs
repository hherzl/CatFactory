using System.Collections.Generic;
using System.Text;
using CatFactory.CodeFactory;
using System.Linq;

namespace CatFactory.Collections
{
    public static class ListExtensions
    {
        public static void Add<T>(this IList<T> list, bool flag, T item)
        {
            if (flag)
            {
                list.Add(item);
            }
        }

        public static StringBuilder ToStringBuilder(this IEnumerable<ILine> list)
        {
            return ToStringBuilder(list.Select(item => item.ToString()));
        }

        public static StringBuilder ToStringBuilder(this IEnumerable<string> list)
        {
            var stringBuilder = new StringBuilder();

            var s = list.Aggregate((current, next) => current.ToString() + "\n" + next.ToString());

            stringBuilder.AppendLine(s);

            return stringBuilder;
        }
    }
}
