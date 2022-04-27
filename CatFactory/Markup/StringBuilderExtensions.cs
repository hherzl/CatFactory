using System.Text;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public static class StringBuilderExtensions
    {
        public static void OpenTag(this StringBuilder stringBuilder, string name, object attributes)
        {
            if (attributes == null)
                stringBuilder.AppendFormat("<{0}>", name);
            else
                stringBuilder.AppendFormat("<{0} {1}>", name, attributes.GetTagAttribs());
        }

        public static void OpenTag(this StringBuilder stringBuilder, string name)
            => stringBuilder.OpenTag(name, null);

        public static void CloseTag(this StringBuilder stringBuilder, string name)
            => stringBuilder.AppendFormat("</{0}>", name);

        public static void AppendTag(this StringBuilder stringBuilder, string name, string content, object attributes)
        {
            if (attributes == null)
                stringBuilder.AppendFormat("<{0}>{1}</{0}>", name, content);
            else
                stringBuilder.AppendFormat("<{0} {2}>{1}</{0}>", name, content, attributes.GetTagAttribs());
        }

        public static void AppendTag(this StringBuilder stringBuilder, string name, string content)
            => stringBuilder.AppendTag(name, content, null);
    }
}
