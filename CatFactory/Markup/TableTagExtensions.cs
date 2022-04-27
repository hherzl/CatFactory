namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public static class TableTagExtensions
    {
        public static TableTag WithHeaders(this TableTag table, params string[] cells)
        {
            foreach (var text in cells)
            {
                table.Head.Cells.Add(new TableCellTag(text));
            }

            return table;
        }

        public static TableTag AddRow(this TableTag table, params string[] cells)
        {
            table.Rows.Add(new TableRowTag(cells));

            return table;
        }
    }
}
