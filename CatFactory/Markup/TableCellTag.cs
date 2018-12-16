namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public class TableCellTag
    {
        /// <summary>
        /// 
        /// </summary>
        public TableCellTag()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public TableCellTag(string text)
        {
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Text { get; set; }
    }
}
