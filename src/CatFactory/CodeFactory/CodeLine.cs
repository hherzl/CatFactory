using System;

namespace CatFactory.CodeFactory
{
    public class CodeLine
    {
        public CodeLine()
        {

        }

        public CodeLine(Int32 indent, String content, params String[] values)
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

        public CodeLine(String content, params String[] values)
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

        public Int32 Indent { get; private set; }

        public String Content { get; private set; }

        public Boolean IsNullOrEmpty
        {
            get
            {
                return String.IsNullOrEmpty(Content);
            }
        }

        public override String ToString()
        {
            return Content;
        }
    }
}
