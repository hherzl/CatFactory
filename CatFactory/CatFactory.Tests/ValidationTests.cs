using System.Linq;
using CatFactory.Mapping;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void ValidateStoreDatabase()
        {
            var db = StoreDatabase.Mock;

            var dbValidator = new DatabaseValidator();

            var result = dbValidator.Validate(db);

            Assert.True(result.Count() == 0);
        }

        [Fact]
        public void ValidateSupermarketDatabase()
        {
            var db = SupermarketDatabase.Mock;

            var dbValidator = new DatabaseValidator();

            var validationMessages = dbValidator.Validate(db);

            Assert.True(validationMessages.Count() > 0);
        }
    }
}
