using System.Linq;
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
                Name = "Store",
                Database = StoreDatabase.Mock,
                OutputDirectory = "C:\\Temp\\CatFactory\\Dapper"
            };

            project.ScaffoldingDefinition += (source, args) =>
            {

            };

            project.ScaffoldedDefinition += (source, args) =>
            {

            };

            project.GlobalSelection(settings =>
            {
                settings.UseStringBuilderForQueries = false;
            });

            project.Select("Sales.Order", settings => settings.UseQueryBuilder = true);

            // Act
            foreach (var table in project.Database.Tables)
            {
                var selection = project.Selections.FirstOrDefault(item => item.Pattern == table.FullName);

                if (selection == null)
                {
                    selection = project.GlobalSelection();
                }

                var codeBuilder = new CSharpClassCodeBuilder
                {
                    ObjectDefinition = project.GetEntityClassDefinition(table, selection),
                    OutputDirectory = project.OutputDirectory,
                    ForceOverwrite = true
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
