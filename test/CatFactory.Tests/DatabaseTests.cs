using System.Linq;
using Xunit;

namespace CatFactory.Tests
{
    public class DatabaseTests
    {
        [Fact]
        public void ValidateContactDatabase()
        {
            // Arrange
            var database = ContactDatabase.Mock;

            // Act
            var contactTypeTable = database.FindTableBySchemaAndName("dbo.ContactType");
            var contactTable = database.FindTableBySchemaAndName("dbo.Contact");
            var contactEmailTable = database.FindTableBySchemaAndName("dbo.ContactEmail");

            // Assert
            Assert.True(contactTypeTable.ForeignKeys.Count == 0);
            Assert.True(contactTable.ForeignKeys.Count == 1);
            Assert.True(contactEmailTable.ForeignKeys.Count == 2);
        }
    }
}
