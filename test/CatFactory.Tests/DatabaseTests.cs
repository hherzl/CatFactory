using System.Linq;
using CatFactory.Mapping;
using CatFactory.Tests.Models;
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
            var contactTypeTable = database.FindTable("dbo.ContactType");
            var contactTable = database.FindTable("dbo.Contact");
            var contactEmailTable = database.FindTable("dbo.ContactEmail");

            // Assert
            Assert.True(contactTypeTable.ForeignKeys.Count == 0);
            Assert.True(contactTable.ForeignKeys.Count == 1);
            Assert.True(contactEmailTable.ForeignKeys.Count == 2);
        }

        [Fact]
        public void ValidateDatabaseTypeMaps()
        {
            // Arrange
            var mappings = DatabaseTypeMapList.Definition;

            // Act
            var mapsForString = mappings.Where(item => item.ClrType == typeof(string)).ToList();
            var mapsForDecimal = mappings.Where(item => item.ClrType == typeof(decimal)).ToList();

            // Arrange
            Assert.True(mapsForString.Count() == 6);
            Assert.True(mapsForDecimal.Count() == 4);
        }

        [Fact]
        public void TestDatabaseTypeMaps()
        {
            // Arrange
            var database = StoreDatabase.Mock;

            // Act
            var table = database.FindTable("Sales.Order");
            var column = table.Columns[0];
            var clrType = database.ResolveType(column);

            // Assert
            Assert.True(clrType.ClrType == typeof(long));
        }
    }
}
