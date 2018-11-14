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
        public static List<TagAttribute> GetTagAttributes(this object obj)
        {
            var items = new List<TagAttribute>();

            foreach (var property in obj.GetType().GetProperties().Where(item => item.CanRead))
                items.Add(new TagAttribute(property.Name.Replace("_", "-"), property.GetValue(obj, null)?.ToString()));

            return items;
        }
    }
}
