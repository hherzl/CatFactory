using System.Collections.Generic;
using System.Text;
using CatFactory.CodeFactory;

namespace CatFactory.Collections
{
    public static class ListExtensions
    {
        public static void Add<T>(this List<T> list, bool flag, T item)
        {
            if (flag)
            {
                list.Add(item);
            }
        }

        public static void AddUnique<T>(this List<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
        }

        public static void AddUnique<T>(this List<T> list, bool flag, T item)
        {
            if (flag && !list.Contains(item))
            {
                list.Add(item);
            }
        }

        public static StringBuilder ToStringBuilder(this List<ILine> list)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in list)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder;
        }

        public static StringBuilder ToStringBuilder(this List<string> list)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in list)
            {
                stringBuilder.AppendLine(item);
            }

            return stringBuilder;
        }
    }
}
