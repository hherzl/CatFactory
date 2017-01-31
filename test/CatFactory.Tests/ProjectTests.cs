using Xunit;

namespace CatFactory.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void TestBuildFeaturesForProject()
        {
            var db = StoreDatabase.Mock;

            var project = new Project()
            {
                Database = db
            };

            project.BuildFeatures();
        }
    }
}
