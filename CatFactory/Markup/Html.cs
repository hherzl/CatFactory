namespace CatFactory.Markup
{
    public static class Html
    {
        public static string GetTag(string tag, object content, object attributes = null)
            => attributes == null ? string.Format("<{0}>{1}</{0}>", tag, content) : string.Format("<{0} {1}>{2}</{0}>", tag, attributes.GetAttributes(), content);

        public static string GetSelfCloseTag(string tag)
            => string.Format("<{0} />", tag);

        public static string A(object content, object attributes = null)
            => GetTag("a", content, attributes);

        public static string B(object content, object attributes = null)
            => GetTag("b", content, attributes);

        public static string Br()
            => GetSelfCloseTag("br");

        public static string Div(object content, object attributes = null)
            => GetTag("div", content, attributes);

        public static string H1(object content, object attributes = null)
            => GetTag("h1", content, attributes);

        public static string H2(object content, object attributes = null)
            => GetTag("h2", content, attributes);

        public static string H3(object content, object attributes = null)
            => GetTag("h3", content, attributes);

        public static string H4(object content, object attributes = null)
            => GetTag("h4", content, attributes);

        public static string H5(object content, object attributes = null)
            => GetTag("h5", content, attributes);

        public static string H6(object content, object attributes = null)
            => GetTag("h6", content, attributes);

        public static string Hr()
            => GetSelfCloseTag("hr");

        public static string I(object content, object attributes = null)
            => GetTag("i", content, attributes);

        public static string P(object content, object attributes = null)
            => GetTag("p", content, attributes);

        public static string Script(string src)
            => GetTag("script", null, new { src = src });

        public static string Span(object content, object attributes = null)
            => GetTag("span", content, attributes);

        public static string Strong(object content, object attributes = null)
            => GetTag("strong", content, attributes);
    }
}
