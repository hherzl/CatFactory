using System;
using System.Text;
using CatFactory.CodeFactory;
using CatFactory.Markup;

namespace CatFactory.Tests
{
    public class HtmlCodeBuilder : CodeBuilder
    {
        public override String FileName
            => String.Format("Document");

        public override String FileExtension
            => "html";

        public override String Code
        {
            get
            {
                var output = new StringBuilder();

                output.OpenTag("html");
                output.AppendLine();

                output.OpenTag("head");
                output.AppendLine();

                output.AppendTag("title", "My title");
                output.AppendLine();

                output.CloseTag("head");
                output.AppendLine();

                output.OpenTag("body");
                output.AppendLine();

                output.AppendTag("h1", "My title", new { style = "font-family: Verdana;" });
                output.AppendLine();

                output.CloseTag("body");
                output.AppendLine();

                output.CloseTag("html");
                output.AppendLine();

                return output.ToString();
            }
        }
    }
}
