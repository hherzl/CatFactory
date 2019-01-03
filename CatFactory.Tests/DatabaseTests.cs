using System.Linq;
using CatFactory.ObjectRelationalMapping;
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
            var database = Databases.Contact;

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
            var mappings = DatabaseTypeMapList.Default;

            // Act
            var mapsForString = mappings.Where(item => item.GetClrType() == typeof(string)).ToList();
            var mapsForDecimal = mappings.Where(item => item.GetClrType() == typeof(decimal)).ToList();

            // Assert
            Assert.True(mapsForString.Count() == 6);
            Assert.True(mapsForDecimal.Count() == 4);
        }

        [Fact]
        public void TestDatabaseTypeMaps()
        {
            // Arrange
            var database = Databases.OnLineStore;

            // Act
            var table = database.FindTable("Sales.Order");
            var column = table.Columns[0];
            var clrType = database.DatabaseTypeMaps.FirstOrDefault(item => item.DatabaseType == column.Type);

            // Assert
            Assert.True(clrType.GetClrType() == typeof(long));
        }

        [Fact]
        public void ValidateIfBigIntHasParent()
        {
            // Arrange
            var mappings = DatabaseTypeMapList.DefinitionWithCustomTypes;

            // Act
            var nameType = mappings.First(item => item.DatabaseType == "bigint");
            var parentType = nameType.GetParentType(mappings);

            // Assert
            Assert.True(parentType == null);
        }

        [Fact]
        public void ValidateIfNameIsNVarchar()
        {
            // Arrange
            var mappings = DatabaseTypeMapList.DefinitionWithCustomTypes;

            // Act
            var nameType = mappings.First(item => item.DatabaseType == "Name");
            var parentType = nameType.GetParentType(mappings);

            // Assert
            Assert.True(nameType.ParentDatabaseType == parentType.DatabaseType);
            Assert.True(nameType.IsUserDefined);
        }

        [Fact]
        public void ValidateIfSpecialNameIsNVarchar()
        {
            // Arrange
            var mappings = DatabaseTypeMapList.DefinitionWithCustomTypes;

            // Act
            var specialNameType = mappings.First(item => item.DatabaseType == "SpecialName");
            var parentType = specialNameType.GetParentType(mappings);

            // Assert
            Assert.True(specialNameType.IsUserDefined);
            Assert.True(parentType.DatabaseType == "nvarchar");
        }

        [Fact]
        public void ValidateIfFlagIsBit()
        {
            // Arrange
            var mappings = DatabaseTypeMapList.DefinitionWithCustomTypes;

            // Act
            var flagType = mappings.First(item => item.DatabaseType == "Flag");
            var parentType = flagType.GetParentType(mappings);

            // Assert
            Assert.True(flagType.IsUserDefined);
            Assert.True(parentType.DatabaseType == "bit");
            Assert.True(parentType.ParentDatabaseType == null);
            Assert.True(parentType.GetClrType() == typeof(bool));
        }
    }
}
