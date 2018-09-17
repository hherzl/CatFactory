using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="name"></param>
        /// <param name="attributes"></param>
        public static void OpenTag(this StringBuilder stringBuilder, string name, object attributes)
        {
            if (attributes == null)
                stringBuilder.AppendFormat("<{0}>", name);
            else
                stringBuilder.AppendFormat("<{0} {1}>", name, attributes.GetAttributes());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="name"></param>
        public static void OpenTag(this StringBuilder stringBuilder, string name)
            => stringBuilder.OpenTag(name, null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="name"></param>
        public static void CloseTag(this StringBuilder stringBuilder, string name)
            => stringBuilder.AppendFormat("</{0}>", name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        public static void AppendTag(this StringBuilder stringBuilder, string name, string content, object attributes)
        {
            if (attributes == null)
                stringBuilder.AppendFormat("<{0}>{1}</{0}>", name, content);
            else
                stringBuilder.AppendFormat("<{0} {2}>{1}</{0}>", name, content, attributes.GetAttributes());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        public static void AppendTag(this StringBuilder stringBuilder, string name, string content)
            => stringBuilder.AppendTag(name, content, null);
    }
}
