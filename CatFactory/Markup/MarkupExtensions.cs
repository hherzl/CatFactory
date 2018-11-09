using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public static class MarkupExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetAttributes(this object obj)
        {
            if (obj == null)
                return string.Empty;

            var items = new List<string>();

            foreach (var property in obj.GetType().GetProperties().Where(item => item.CanRead))
                items.Add(string.Format("{0}=\"{1}\"", property.Name.Replace("_", "-"), property.GetValue(obj, null)));

            return string.Format(" {0}", string.Join(" ", items));
        }
    }
}
