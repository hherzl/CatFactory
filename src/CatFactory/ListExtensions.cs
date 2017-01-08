using System;
using System.Collections.Generic;

namespace CatFactory
{
    public static class ListExtensions
    {
        public static void Add<T>(List<T> list, Boolean flag, T item)
        {
            if (flag)
            {
                list.Add(item);
            }
        }
    }
}
