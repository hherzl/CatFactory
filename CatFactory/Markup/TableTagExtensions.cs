namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public static class TableTagExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="cells"></param>
        /// <returns></returns>
        public static TableTag WithHeaders(this TableTag table, params string[] cells)
        {
            foreach (var text in cells)
            {
                table.Header.Cells.Add(new TableCellTag(text));
            }

            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="cells"></param>
        /// <returns></returns>
        public static TableTag AddRow(this TableTag table, params string[] cells)
        {
            table.Rows.Add(new TableRowTag(cells));

            return table;
        }
    }
}
