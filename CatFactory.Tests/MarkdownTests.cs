using System.IO;
using CatFactory.Markdown;
using Xunit;

namespace CatFactory.Tests
{
    public class MarkdownTests
    {
        [Fact]
        public void TestCodeChallengeReadMeMd()
        {
            var readme = new MdDocument();

            readme.H1("CodeChallenge");

            readme.WriteLine("This is the repository for {0} Code Challenge.", Md.Italics("Snacks API"));

            readme.H2("Technologies");

            readme.WriteLine("This solution is built with the following technologies:");

            readme.H3("Back-end");

            readme.UnorderedList("ASP.NET Core", "Entity Framework Core");

            readme.H3("Front-end");

            readme.UnorderedList("Angular 6", "Angular Material 6");

            readme.H2("Executing Solution");

            readme.H3("Prerequisites");

            readme.WriteLine("In order to run this solution, install the following components:");

            readme.UnorderedList(".NET Core", "NodeJS", "Angular CLI");

            readme.H3("First Run");

            readme.WriteLine("If is the first run, execute {0} file inside of {1} directory.", Md.Italics("build.bat"), Md.Italics("SourceCode"));

            readme.WriteLine("Then execute {0} file from {1} directory.", Md.Italics("deploy.bat"), Md.Italics("Database"));

            readme.WriteLine(Md.Italics("To deploy database script, you need access to SQL Server instance."));

            readme.H3("Running Solution");

            readme.WriteLine("Execute {0} file inside of {1} directory.", Md.Italics("run.bat"), Md.Italics("SourceCode"));

            readme.UnorderedList(
                string.Format("{0} project runs on {1} port.", Md.Bold("AuthAPI"), Md.Italics("5600")),
                string.Format("{0} project runs on {1} port.", Md.Bold("API"), Md.Italics("5700")),
                string.Format("Angular client runs on {0} port.", Md.Italics("4200"))
                );

            readme.H4("API Help Page");

            readme.WriteLine("Open {0} url in browser:", Md.Italics("http://localhost:5700/swagger/index.html"));

            readme.H4("Client");

            readme.WriteLine("![Help Api Page](HelpApiPage.jpg)");

            readme.H3("Tests");

            readme.WriteLine("There is a collection for Postman Inside of {0} directory.", Md.Italics("Tests"));

            File.WriteAllText("C:\\Temp\\CatFactory\\codechallenge.README.md", readme.ToString());
        }

        [Fact]
        public void TestTestsReadMeMd()
        {
            var readme = new MdDocument();

            readme.H1("Tests for Snacks API");

            readme.WriteLine("{0} file contains the following tests for {1}:", Md.Italics("Store API.postman_collection.json"), Md.Bold("Snacks API"));

            readme.Write(
                new MdTable
                {
                    Headers =
                    {
                        new MdTableHeader("Name"),
                        new MdTableHeader("Requires Authentication"),
                        new MdTableHeader("Role"),
                        new MdTableHeader("Description")
                    },
                    Rows =
                    {
                        new MdTableRow("Get Products", "No", "None", "Retrieves products"),
                        new MdTableRow("Get Products by Name", "No", "None", "Retrieves products filtering by name")
                    }
                }
            );

            File.WriteAllText("C:\\Temp\\CatFactory\\tests.README.md", readme.ToString());
        }
    }
}
