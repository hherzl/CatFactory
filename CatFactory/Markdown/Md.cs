namespace CatFactory.Markdown
{
    /// <summary>
    /// Provides static methods for markdown syntax
    /// </summary>
    /// <remarks>For more info: https://en.wikipedia.org/wiki/Markdown</remarks>
    public static class Md
    {
        /// <summary>
        /// Gets a bold string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a bold string in MD</returns>
        public static string Bold(string text)
            => string.Format("**{0}**", text);

        /// <summary>
        /// Gets a header 1 string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a header 1 string in MD</returns>
        public static string H1(string text)
            => string.Format("# {0}", text);

        /// <summary>
        /// Gets a header 2 string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a header 2 string in MD</returns>
        public static string H2(string text)
            => string.Format("## {0}", text);

        /// <summary>
        /// Gets a header 3 string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a header 3 string in MD</returns>
        public static string H3(string text)
            => string.Format("### {0}", text);

        /// <summary>
        /// Gets a header 4 string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a header 4 string in MD</returns>
        public static string H4(string text)
            => string.Format("#### {0}", text);

        /// <summary>
        /// Gets a header 5 string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a header 5 string in MD</returns>
        public static string H5(string text)
            => string.Format("##### {0}", text);

        /// <summary>
        /// Gets a header 6 string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a header 6 string in MD</returns>
        public static string H6(string text)
            => string.Format("###### {0}", text);

        /// <summary>
        /// Gets a horizontal line string
        /// </summary>
        /// <returns>A string that represents a horizontal line string in MD</returns>
        public static string HorizontalRule()
            => "---";

        /// <summary>
        /// Gets an image string
        /// </summary>
        /// <param name="altText">Alternate text</param>
        /// <param name="url">Image Url</param>
        /// <returns>A string that represents an image string in MD</returns>
        public static string Image(string altText, string url)
            => string.Format("![{0}]({1})", altText, url);

        /// <summary>
        /// Gets an image string
        /// </summary>
        /// <param name="altText">Alternate text</param>
        /// <param name="url">Image url</param>
        /// <param name="tooltip">Image tooltip</param>
        /// <returns>A string that represents an image string in MD</returns>
        public static string Image(string altText, string url, string tooltip)
            => string.Format("![{0}]({1} \"{2}\")", altText, url, tooltip);

        /// <summary>
        /// Gets an item string
        /// </summary>
        /// <param name="enumerator">Enumerator character</param>
        /// <param name="text">Item text</param>
        /// <returns></returns>
        public static string Item(string enumerator, string text)
            => string.Format("{0} {1}", enumerator, text);

        /// <summary>
        /// Gets an italics string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents an italics string in MD</returns>
        public static string Italics(string text)
            => string.Format("*{0}*", text);

        /// <summary>
        /// Gets a link string
        /// </summary>
        /// <param name="text">Link text</param>
        /// <param name="url">Link url</param>
        /// <returns>A string that represents a link string in MD</returns>
        public static string Link(string text, string url)
            => string.Format("[`{0}`]({1})", text, url);

        /// <summary>
        /// Gets a link string
        /// </summary>
        /// <param name="text">Link text</param>
        /// <param name="url">Link url</param>
        /// <param name="title">Link title</param>
        /// <returns>A string that represents a link string in MD</returns>
        public static string Link(string text, string url, string title)
            => string.Format("[{0}]({1} \"{2}\")", text, url, title);

        /// <summary>
        /// Gets a strikethrough string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>A string that represents a strikethrough string in MD</returns>
        public static string Strikethrough(string text)
            => string.Format("~~{0}~~", text);
    }
}
