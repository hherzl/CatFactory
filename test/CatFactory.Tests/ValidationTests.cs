using System.Linq;
using CatFactory.Mapping;
using Xunit;

namespace CatFactory.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void ValidateMockDatabase()
        {
            var db = Mocks.SalesDatabase;

            var dbValidator = new DatabaseValidator();

            var result = dbValidator.Validate(db);

            Assert.True(result.Count() == 0);
        }
    }
}
