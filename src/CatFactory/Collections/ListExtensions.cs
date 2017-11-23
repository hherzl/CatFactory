using System.Collections.Generic;
using System.Text;
using CatFactory.CodeFactory;

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

        public static void AddUnique<T>(this IList<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
        }

        public static void AddUnique<T>(this IList<T> list, bool flag, T item)
        {
            if (flag && !list.Contains(item))
            {
                list.Add(item);
            }
        }

        public static StringBuilder ToStringBuilder(this IList<ILine> list)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in list)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder;
        }

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
