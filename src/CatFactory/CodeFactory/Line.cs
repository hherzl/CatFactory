using System;

namespace CatFactory.CodeFactory
{
    public class Line : ILine
    {
        public Line()
        {
        }

        public Line(Int32 indent, String content, params String[] values)
        {
            Indent = indent;

            if (values == null)
            {
                Content = content;
            }
            else
            {
                Content = String.Format(content, values);
            }
        }

        public Line(String content, params String[] values)
        {
            Content = content;

            if (values == null)
            {
                Content = content;
            }
            else
            {
                Content = String.Format(content, values);
            }
        }

        public Int32 Indent { get; protected set; }

        public String Content { get; protected set; }

        public Boolean IsNullOrEmpty
            => String.IsNullOrEmpty(Content);
    }
}
