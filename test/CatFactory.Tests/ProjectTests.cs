using Xunit;

namespace CatFactory.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void TestProject()
        {
            var db = Mocks.SalesDatabase;

            var project = new Project()
            {
                Database = db
            };

            project.BuildFeatures();
        }
    }
}
