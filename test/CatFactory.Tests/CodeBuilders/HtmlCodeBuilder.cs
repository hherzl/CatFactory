using System.Text;
using CatFactory.CodeFactory;
using CatFactory.Markup;

namespace CatFactory.Tests.CodeBuilders
{
    public class HtmlCodeBuilder : CodeBuilder
    {
        public override string FileName
            => "Document";

        public override string FileExtension
            => "html";

        public override string Code
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

                output.Append(Html.H1("My title", new { style = "font-family: Verdana;" }));
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
