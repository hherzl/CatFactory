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
                Name = "OnlineStore",
                Database = Databases.OnlineStore,
                OutputDirectory = @"C:\Temp\CatFactory\EntityFrameworkCore",
                AuthorInfo = new AuthorInfo
                {
                    Name = "Hans H.",
                    Email = "hansh@catfactory.org"
                }
            };

            project.BuildFeatures();

            project.GlobalSelection(settings =>
            {
                settings.UseDataAnnotations = true;
                settings.AddDataBindings = true;
            });

            project.Selection("Sales.OrderHeader", settings => settings.EntitiesWithDataContracts = true);

            project.ScaffoldingDefinition += (source, args) =>
            {
            };

            project.ScaffoldedDefinition += (source, args) =>
            {
            };

            // Act
            project.Scaffold();

            // Assert
            Assert.True(project.Selections.Count == 2);
        }
    }
}
