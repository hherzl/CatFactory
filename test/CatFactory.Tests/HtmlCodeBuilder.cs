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

                output.OpenTag("head");

                output.AppendTag("title", content: "My title");

                output.CloseTag("head");

                output.OpenTag("body");

                output.AppendTag("h1", "My title", new { style = "font-family: Verdana;" });

                output.CloseTag("body");

                output.CloseTag("html");

                return output.ToString();
            }
        }
    }
}
