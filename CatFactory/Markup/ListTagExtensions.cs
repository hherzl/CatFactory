namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public static class ListTagExtensions
    {
        public static ListTag Li(this ListTag list, string text)
        {
            list.Children.Add(new Tag { Name = "li", Content = text });

            return list;
        }
    }
}
