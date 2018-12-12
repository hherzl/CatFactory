namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public static class ListTagExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static ListTag Li(this ListTag list, string text)
        {
            list.Children.Add(new Tag { Name = "li", Content = text });

            return list;
        }
    }
}
