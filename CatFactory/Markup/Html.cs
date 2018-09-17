namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public static class Html
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string GetTag(string tag, object content, object attributes = null)
            => attributes == null ? string.Format("<{0}>{1}</{0}>", tag, content) : string.Format("<{0} {1}>{2}</{0}>", tag, attributes.GetAttributes(), content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static string GetSelfCloseTag(string tag)
            => string.Format("<{0} />", tag);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string A(object content, object attributes = null)
            => GetTag("a", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string B(object content, object attributes = null)
            => GetTag("b", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string Br()
            => GetSelfCloseTag("br");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string Div(object content, object attributes = null)
            => GetTag("div", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string H1(object content, object attributes = null)
            => GetTag("h1", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string H2(object content, object attributes = null)
            => GetTag("h2", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string H3(object content, object attributes = null)
            => GetTag("h3", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string H4(object content, object attributes = null)
            => GetTag("h4", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string H5(object content, object attributes = null)
            => GetTag("h5", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string H6(object content, object attributes = null)
            => GetTag("h6", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string Hr()
            => GetSelfCloseTag("hr");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string I(object content, object attributes = null)
            => GetTag("i", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string P(object content, object attributes = null)
            => GetTag("p", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static string Script(string src)
            => GetTag("script", null, new { src = src });

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string Span(object content, object attributes = null)
            => GetTag("span", content, attributes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static string Strong(object content, object attributes = null)
            => GetTag("strong", content, attributes);
    }
}
