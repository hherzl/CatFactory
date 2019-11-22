namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public static class Html
    {
        public static Tag A(object content, object attribs = null)
            => new Tag
            {
                Name = "a",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag B(object content, object attribs = null)
            => new Tag
            {
                Name = "b",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag Br()
            => new Tag
            {
                Name = "br",
                IsSelfClosed = true
            };

        public static Tag Div(object content, object attribs = null)
            => new Tag
            {
                Name = "div",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag Hr()
            => new Tag
            {
                Name = "hr",
                IsSelfClosed = true
            };

        public static Tag I(object content, object attribs = null)
            => new Tag
            {
                Name = "i",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag P(object content, object attribs = null)
            => new Tag
            {
                Name = "p",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag H1(object content, object attribs = null)
            => new Tag
            {
                Name = "h1",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag H2(object content, object attribs = null)
            => new Tag
            {
                Name = "h2",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag H3(object content, object attribs = null)
            => new Tag
            {
                Name = "h3",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag H4(object content, object attribs = null)
            => new Tag
            {
                Name = "h4",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag H5(object content, object attribs = null)
            => new Tag
            {
                Name = "h5",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag H6(object content, object attribs = null)
            => new Tag
            {
                Name = "h5",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static ListTag Ol(object attribs = null)
            => new ListTag
            {
                Name = "ol",
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag Script(string src)
            => new Tag
            {
                Name = "script",
                Attributes = new { src }.GetTagAttribs()
            };

        public static Tag Span(object content, object attribs = null)
            => new Tag
            {
                Name = "span",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static TableTag Table(object attribs = null)
            => new TableTag
            {
                Name = "table",
                Attributes = attribs.GetTagAttribs()
            };

        public static Tag Strong(object content, object attribs = null)
            => new Tag
            {
                Name = "strong",
                Content = content.ToString(),
                Attributes = attribs.GetTagAttribs()
            };

        public static ListTag Ul(object attribs = null)
            => new ListTag
            {
                Name = "ul",
                Attributes = attribs.GetTagAttribs()
            };
    }
#pragma warning restore CS1591
}
