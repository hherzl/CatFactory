using Xunit;

namespace CatFactory.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void TestBuildFeaturesForProject()
        {
            // Arrange
            var project = new Project
            {
                Name = "Store",
                Database = StoreDatabase.Mock
            };

            // Act
            project.BuildFeatures();

            // Assert
            Assert.True(project.Features.Count == 4);
        }
    }
}
