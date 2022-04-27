using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public static class MarkupExtensions
    {
        public static List<TagAttribute> GetTagAttribs(this object obj)
        {
            var items = new List<TagAttribute>();

            if (obj != null)
            {
                foreach (var property in obj.GetType().GetProperties().Where(item => item.CanRead))
                {
                    items.Add(new TagAttribute(property.Name.Replace("_", "-"), property.GetValue(obj, null)?.ToString()));
                }
            }

            return items;
        }
    }
}
