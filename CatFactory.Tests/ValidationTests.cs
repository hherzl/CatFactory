using CatFactory.ObjectRelationalMapping.Validation;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void ValidateStoreDatabase()
        {
            // Arrange
            var db = StoreDatabase.Mock;
            var dbValidator = new DatabaseValidator();

            // Act
            var result = dbValidator.Validate(db);

            // Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void ValidateSupermarketDatabase()
        {
            // Arrange
            var db = SupermarketDatabase.Mock;
            var dbValidator = new DatabaseValidator();

            // Act
            var result = dbValidator.Validate(db);

            // Assert
            Assert.False(result.IsValid);
            Assert.True(result.ValidationMessages.Count == 4);
        }
    }
}
