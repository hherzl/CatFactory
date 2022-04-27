using System.IO;
using System.Text;
using CatFactory.Markup;
using Xunit;

namespace CatFactory.Tests
{
    public class MarkupTests
    {
        [Fact]
        public void BuildHtmlTag()
        {
            var tag = Tag.Create("p", new { style = "font-weight: bold;" });

            Assert.True(tag.ToString() == "<p style=\"font-weight: bold;\"></p>");
        }

        [Fact]
        public void BuildSelfCloseHtmlTag()
        {
            var tag = Tag.Create("hr", isSelfClosed: true);

            Assert.True(tag.ToString() == "<hr />");
        }

        [Fact]
        public void BuildWebFormTag()
        {
            var tag = Tag.Create("TextBox", new { runat = "server", Text = "Hello from CatFactory uni tests!" }, ns: "asp");

            Assert.True(tag.ToString() == "<asp:TextBox runat=\"server\" Text=\"Hello from CatFactory uni tests!\"></asp:TextBox>");
        }

        [Fact]
        public void BuildResponseTag()
        {
            var tag = Tag.Create("response", new { code = "200" }, content: "A success response");

            Assert.True(tag.ToString() == "<response code=\"200\">A success response</response>");
        }

        [Fact]
        public void CreateHtmlDocument()
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

            File.WriteAllText(@"C:\Temp\CatFactory\HtmlDocument.html", html.ToString());
        }

        [Fact]
        public void CreateOrderedList()
        {
            var movies = Html.Ol(new { color = "red" })
                .Li("Batman Begins")
                .Li("Batman Dark Knight")
                .Li("Batman Dark Knight Rises");

            File.WriteAllText(@"C:\Temp\CatFactory\OlMovies.html", movies.ToString());
        }

        [Fact]
        public void CreateUnorderedList()
        {
            var drinks = Html.Ul()
                .Li("Beer")
                .Li("Wine")
                .Li("Sake");

            File.WriteAllText(@"C:\Temp\CatFactory\UlDrinks.html", drinks.ToString());
        }

        [Fact]
        public void CreateTable()
        {
            var table = Html.Table(new { style = "border: 1px solid Black;" })
                .WithHeaders("First name", "Middle name", "Last name")
                .AddRow("Erick", "T", "Cartman")
                .AddRow("Kyle", "", "Broflovski")
                .AddRow("Stan", "", "Marsh")
                .AddRow("Kenny", "", "McCormick");

            File.WriteAllText(@"C:\Temp\CatFactory\Table.html", table.ToString());
        }
    }
}
