namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public class TableCellTag : Tag
    {
        public TableCellTag()
            : base()
        {
        }

        public TableCellTag(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
