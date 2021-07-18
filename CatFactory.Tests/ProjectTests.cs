using CatFactory.CodeFactory.Scaffolding;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void BuildFeaturesForProject()
        {
            // Arrange
            var project = new Project<ProjectSettings>
            {
                Name = "OnlineStore",
                Database = Databases.OnlineStore
            };

            // Act
            project.BuildFeatures();

            // Assert
            Assert.True(project.Features.Count == 4);
        }
    }
}
