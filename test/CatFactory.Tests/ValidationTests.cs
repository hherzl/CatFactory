using System.Linq;
using CatFactory.Mapping;
using Xunit;

namespace CatFactory.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void ValidateStoreDatabase()
        {
            var db = Mocks.StoreDatabase;

            var dbValidator = new DatabaseValidator();

            var result = dbValidator.Validate(db);

            Assert.True(result.Count() == 0);
        }

        [Fact]
        public void ValidateSupermarketDatabase()
        {
            var db = Mocks.SupermarketDatabase;

            var dbValidator = new DatabaseValidator();

            var validationMessages = dbValidator.Validate(db);

            Assert.True(validationMessages.Count() > 0);
        }
    }
}
