using System.Text;
using CatFactory.Markup;
using Xunit;

namespace CatFactory.Tests
{
    public class MarkupTests
    {
        [Fact]
        public void TestHtmlCodeBuilder()
        {
            var codeBuilder = new HtmlCodeBuilder
            {
                OutputDirectory = "C:\\Temp\\CatFactory",
                ForceOverwrite = true
            };

            codeBuilder.CreateFile();
        }

        [Fact]
        public void TestHtmlDocument()
        {
            var html = new StringBuilder();

            html.OpenTag("html");
            html.AppendLine();

            html.OpenTag("head");
            html.AppendLine();

            html.AppendTag("title", "Document Generated with CatFactory");
            html.AppendLine();

            html.CloseTag("head");
            html.AppendLine();

            html.OpenTag("body");
            html.AppendLine();

            html.AppendTag("h1", "CatFactory ==^^==");
            html.AppendLine();

            html.AppendTag("p", "This is a test for append tag method", new { style = "text-align: center;" });
            html.AppendLine();

            html.CloseTag("body");
            html.AppendLine();

            html.AppendTag("script", string.Empty, new { src = "./foo.js" });
            html.AppendLine();

            html.CloseTag("html");
            html.AppendLine();

            TextFileHelper.CreateFile("C:\\Temp\\CatFactory\\HtmlDocument.html", html.ToString());
        }
    }
}
