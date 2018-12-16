using System.IO;
using System.Text;
using CatFactory.Markup;
using Xunit;

namespace CatFactory.Tests
{
    public class MarkupTests
    {
        [Fact]
        public void TestHtmlTag()
        {
            var tag = new Tag
            {
                Name = "p",
                Attributes =
                {
                    new TagAttribute("style", "font-weight: bold;")
                }
            };

            Assert.True(tag.ToString() == "<p style=\"font-weight: bold;\"></p>");
        }

        [Fact]
        public void TestSelfCloseHtmlTag()
        {
            var tag = new Tag
            {
                Name = "hr",
                IsSelfClosed = true
            };

            Assert.True(tag.ToString() == "<hr />");
        }

        [Fact]
        public void TestWebFormTag()
        {
            var tag = new Tag
            {
                Namespace = "asp",
                Name = "TextBox",
                Attributes =
                {
                    new TagAttribute("runat", "server"),
                    new TagAttribute("Text", "Hello from CatFactory uni tests!")
                }
            };

            Assert.True(tag.ToString() == "<asp:TextBox runat=\"server\" Text=\"Hello from CatFactory uni tests!\"></asp:TextBox>");
        }

        [Fact]
        public void TestResponseTag()
        {
            var tag = new Tag
            {
                Name = "response",
                Attributes =
                {
                    new TagAttribute("code", "200")
                },
                Content = "A success response"
            };

            Assert.True(tag.ToString() == "<response code=\"200\">A success response</response>");
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

            html.Append(Html.P("This is a test for append tag method", new { style = "text-align: center;" }));
            html.AppendLine();

            html.CloseTag("body");
            html.AppendLine();

            html.Append(Html.Script("./foo.js"));
            html.AppendLine();

            html.CloseTag("html");
            html.AppendLine();

            File.WriteAllText("C:\\Temp\\CatFactory\\HtmlDocument.html", html.ToString());
        }

        [Fact]
        public void TestOrderedList()
        {
            var drinks = Html.Ol(new { color = "red" })
                .Li("Batman Begins")
                .Li("Batman Dark Knight")
                .Li("Batman Dark Knight Rises");

            File.WriteAllText("C:\\Temp\\CatFactory\\OlMovies.html", drinks.ToString());
        }

        [Fact]
        public void TestUnorderedList()
        {
            var drinks = Html.Ul()
                .Li("Beer")
                .Li("Wine")
                .Li("Sake");

            File.WriteAllText("C:\\Temp\\CatFactory\\UlDrinks.html", drinks.ToString());
        }

        [Fact]
        public void TestTable()
        {
            var table = Html.Table(new { style = "border: 1px solid Black;" })
                .WithHeaders("First name", "Middle name", "Last name")
                .AddRow("Erick", "T", "Cartman")
                .AddRow("Kyle", "", "Broflovski")
                .AddRow("Stan", "", "Marsh")
                .AddRow("Kenny", "", "McCormick")
                ;

            File.WriteAllText("C:\\Temp\\CatFactory\\Table.html", table.ToString());
        }
    }
}
