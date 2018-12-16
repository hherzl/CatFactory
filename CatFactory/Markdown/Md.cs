namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class Md
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Bold(string text)
            => string.Format("**{0}**", text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string H1(string text)
            => string.Format("# {0}", text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string H2(string text)
            => string.Format("## {0}", text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string H3(string text)
            => string.Format("### {0}", text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string H4(string text)
            => string.Format("#### {0}", text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string H5(string text)
            => string.Format("##### {0}", text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string H6(string text)
            => string.Format("###### {0}", text);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string HorizontalRule()
            => "---";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="altText"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Image(string altText, string url)
            => string.Format("![{0}]({1})", altText, url);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="altText"></param>
        /// <param name="url"></param>
        /// <param name="tooltip"></param>
        /// <returns></returns>
        public static string Image(string altText, string url, string tooltip)
            => string.Format("![{0}]({1} \"{2}\")", altText, url, tooltip);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumerator"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Item(string enumerator, string text)
            => string.Format("{0} {1}", enumerator, text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Italics(string text)
            => string.Format("*{0}*", text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Link(string text, string url)
            => string.Format("[{0}]({1})", text, url);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="url"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string Link(string text, string url, string title)
            => string.Format("[{0}]({1} \"{2}\")", text, url, title);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Strikethrough(string text)
            => string.Format("~~{0}~~", text);
    }
}
