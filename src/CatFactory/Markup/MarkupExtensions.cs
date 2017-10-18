using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CatFactory.Markup
{
    public static class MarkupExtensions
    {
        private static string GetAttributes(this object attributes)
        {
            var items = new List<string>();

            foreach (var property in attributes.GetType().GetProperties().Where(item => item.CanRead))
            {
                items.Add(string.Format("{0}=\"{1}\"", property.Name.Replace("-", "_"), property.GetValue(attributes, null)));
            }

            return string.Join(" ", items);
        }

        public static void OpenTag(this StringBuilder stringBuilder, string name, object attributes)
        {
            if (attributes == null)
            {
                stringBuilder.AppendFormat("<{0}>", name);
            }
            else
            {
                stringBuilder.AppendFormat("<{0} {1}>", name, attributes.GetAttributes());
            }
        }

        public static void OpenTag(this StringBuilder stringBuilder, string name)
        {
            stringBuilder.OpenTag(name, null);
        }

        public static void CloseTag(this StringBuilder stringBuilder, string name)
        {
            stringBuilder.AppendFormat("</{0}>", name);
        }

        public static void AppendTag(this StringBuilder stringBuilder, string name, string content, object attributes)
        {
            if (attributes == null)
            {
                stringBuilder.AppendFormat("<{0}>{1}</{0}>", name, content);
            }
            else
            {
                stringBuilder.AppendFormat("<{0} {2}>{1}</{0}>", name, content, attributes.GetAttributes());
            }
        }

        public static void AppendTag(this StringBuilder stringBuilder, string name, string content)
        {
            stringBuilder.AppendTag(name, content, null);
        }
    }
}
