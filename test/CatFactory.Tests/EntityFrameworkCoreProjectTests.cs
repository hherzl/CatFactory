using System.Linq;
using CatFactory.Tests.CodeBuilders;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public class EntityFrameworkCoreProjectTests
    {
        [Fact]
        public void TestEntityFrameworkCoreProject()
        {
            // Arrange
            var project = new EntityFrameworkCoreProject
            {
                Name = "Store",
                Database = StoreDatabase.Mock,
                OutputDirectory = "C:\\Temp\\CatFactory\\EntityFrameworkCore"
            };

            project.BuildFeatures();

            project.GlobalSelection(settings =>
            {
                settings.UseDataAnnotations = true;
                settings.AddDataBindings = true;
            });

            project.Select("Sales.Order", settings => settings.EntitiesWithDataContracts = true);

            project.ScaffoldingDefinition += (source, args) =>
            {

            };

            project.ScaffoldedDefinition += (source, args) =>
            {

            };

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
