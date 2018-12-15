namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MdTableHeader
    {
        /// <summary>
        /// 
        /// </summary>
        public MdTableHeader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public MdTableHeader(string text)
        {
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Text { get; set; }
    }
}
