using System.Collections.Generic;
using System.Text;
using CatFactory.CodeFactory;

namespace CatFactory.Collections
{
    /// <summary>
    /// 
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="flag"></param>
        /// <param name="item"></param>
        public static void Add<T>(this IList<T> list, bool flag, T item)
        {
            if (flag)
                list.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="item"></param>
        public static void AddUnique<T>(this IList<T> list, T item)
        {
            if (!list.Contains(item))
                list.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="flag"></param>
        /// <param name="item"></param>
        public static void AddUnique<T>(this IList<T> list, bool flag, T item)
        {
            if (flag && !list.Contains(item))
                list.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static StringBuilder ToStringBuilder(this IList<ILine> list)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in list)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder;
        }
    }
}
