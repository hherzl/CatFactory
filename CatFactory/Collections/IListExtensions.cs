using System.Collections.Generic;
using System.Text;
using CatFactory.CodeFactory;

namespace CatFactory.Collections
{
    /// <summary>
    /// Provides extension methods for <see cref="IList{T}"/> interface
    /// </summary>
    public static class IListExtensions
    {
        /// <summary>
        /// Adds an item of <typeparamref name="TItem"/> type
        /// </summary>
        /// <typeparam name="TItem"><typeparamref name="TItem"/> object</typeparam>
        /// <param name="list">List</param>
        /// <param name="flag">Condition</param>
        /// <param name="item">Item</param>
        public static void Add<TItem>(this IList<TItem> list, bool flag, TItem item)
        {
            if (flag)
                list.Add(item);
        }

        /// <summary>
        /// Adds an item of <typeparamref name="TItem"/> type if not exists in list
        /// </summary>
        /// <typeparam name="TItem"><typeparamref name="TItem"/> object</typeparam>
        /// <param name="list">List</param>
        /// <param name="item">Item</param>
        public static void AddUnique<TItem>(this IList<TItem> list, TItem item)
        {
            if (!list.Contains(item))
                list.Add(item);
        }

        /// <summary>
        /// Adds an item of <typeparamref name="TItem"/> type if not exists in list
        /// </summary>
        /// <typeparam name="TItem"><typeparamref name="TItem"/> object</typeparam>
        /// <param name="list">List</param>
        /// <param name="flag">condition</param>
        /// <param name="item">Item</param>
        public static void AddUnique<TItem>(this IList<TItem> list, bool flag, TItem item)
        {
            if (flag && !list.Contains(item))
                list.Add(item);
        }

        /// <summary>
        /// Gets an instance of <see cref="StringBuilder"/> that contains all content from <see cref="IList{ILine}"/> list
        /// </summary>
        /// <param name="list">Implementation of <see cref="IList{T}"/> interface</param>
        /// <returns>An instance of <see cref="StringBuilder"/> that contains all content from <see cref="IList{ILine}"/> list</returns>
        public static StringBuilder ToStringBuilder(this IList<ILine> list)
        {
            var output = new StringBuilder();

            foreach (var item in list)
            {
                output.AppendLine(item.ToString());
            }

            return output;
        }
    }
}
