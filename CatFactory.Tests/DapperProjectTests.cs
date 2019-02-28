using System.Linq;
using CatFactory.CodeFactory;
using CatFactory.Tests.CodeBuilders;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public class DapperProjectTests
    {
        [Fact]
        public void TestDapperProject()
        {
            // Arrange
            var project = new DapperProject
            {
                Name = "OnlineStore",
                Database = Databases.OnlineStore,
                OutputDirectory = "C:\\Temp\\CatFactory\\Dapper",
                AuthorInfo = new AuthorInfo
                {
                    Name = "Hans H.",
                    Email = "hansh@catfactory.org"
                }
            };

            project.ScaffoldingDefinition += (source, args) =>
            {
            };

            project.ScaffoldedDefinition += (source, args) =>
            {
            };

            project.GlobalSelection(settings => settings.UseStringBuilderForQueries = false);

            project.Selection("Sales.Order", settings => settings.UseQueryBuilder = true);

            // Act
            foreach (var table in project.Database.Tables)
            {
                var selection = project.Selections.FirstOrDefault(item => item.Pattern == table.FullName) ?? project.GlobalSelection();

                var codeBuilder = new CSharpClassCodeBuilder
                {
                    ObjectDefinition = project.GetEntityClassDefinition(table, selection),
                    OutputDirectory = project.OutputDirectory,
                    ForceOverwrite = true
                };

                codeBuilder.TranslatedDefinition += (source, args) =>
                {
                    if (project.AuthorInfo != null)
                    {
                        codeBuilder.Lines.Insert(0, new CommentLine("// Author name: {0}", project.AuthorInfo.Name));
                        codeBuilder.Lines.Insert(1, new CommentLine("// Email: {0}", project.AuthorInfo.Email));
                        codeBuilder.Lines.Insert(2, new CodeLine());
                    }
                };

                project.Scaffolding(codeBuilder);

                codeBuilder.CreateFile();

                project.Scaffolded(codeBuilder);
            }

            // Assert
            Assert.True(project.Selections.Count == 2);
        }
    }
}
