using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CatFactory.Markup
{
    public static class MarkupExtensions
    {
        public static String GetAttributes(this Object attributes)
        {
            var items = new List<String>();

            foreach (var property in attributes.GetType().GetProperties())
            {
                items.Add(String.Format("{0}=\"{1}\"", property.Name.Replace("-", "_"), property.GetValue(attributes, null)));
            }

            return String.Join(" ", items);
        }

        public static void OpenTag(this StringBuilder sb, String name, Object attributes = null)
        {
            if (attributes == null)
            {
                sb.AppendFormat("<{0}>", name);
            }
            else
            {
                sb.AppendFormat("<{0} {1}>", name, attributes.GetAttributes());
            }
        }
        
        public static void CloseTag(this StringBuilder sb, String name)
        {
            sb.AppendFormat("</{0}>", name);
        }

        public static void AppendTag(this StringBuilder sb, String name, Object attributes = null)
        {
            if (attributes == null)
            {
                sb.AppendFormat("<{0}></{0}>", name);
            }
            else
            {
                sb.AppendFormat("<{0} {1}></{0}>", name, attributes.GetAttributes());
            }
        }

        public static void AppendTag(this StringBuilder sb, String name, Object content, Object attributes = null)
        {
            if (attributes == null)
            {
                sb.AppendFormat("<{0}>{1}</{0}>", name, content);
            }
            else
            {
                sb.AppendFormat("<{0} {1}>{2}</{0}>", name, attributes.GetAttributes(), content);
            }
        }
    }
}
