using System;
using System.Collections.Generic;

namespace CatFactory.Collections
{
    public static class ListExtensions
    {
        public static void Add<T>(this List<T> list, Boolean flag, T item)
        {
            if (flag)
            {
                list.Add(item);
            }
        }
    }
}
