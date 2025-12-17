using System.Linq;
using CatFactory.ObjectRelationalMapping;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests;

public class DatabaseTests
{
    [Fact]
    public void ValidateContactDatabase()
    {
        // Arrange
        var db = Databases.Contact;

        db.ImportBag.Foo = "foo";

        // Act
        var contactTypeTable = db.FindTable("dbo.ContactType");
        var contactTable = db.FindTable("dbo.Contact");
        var contactEmailTable = db.FindTable("dbo.ContactEmail");

        // Assert
        Assert.Empty(contactTypeTable.ForeignKeys);
        Assert.Single(contactTable.ForeignKeys);
        Assert.Equal(2, contactEmailTable.ForeignKeys.Count);
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
        Assert.Equal(6, mapsForString.Count);
        Assert.Equal(4, mapsForDecimal.Count);
    }

    [Fact]
    public void DatabaseTypeMaps()
    {
        // Arrange
        var db = Databases.OnlineStore;

        // Act
        var table = db.FindTable("Sales.OrderHeader");
        var column = table.Columns[0];
        var clrType = db.DatabaseTypeMaps.FirstOrDefault(item => item.DatabaseType == column.Type);

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
        Assert.Null(parentType);
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
        Assert.Equal("nvarchar", parentType.DatabaseType);
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
        Assert.Equal("bit", parentType.DatabaseType);
        Assert.Null(parentType.ParentDatabaseType);
        Assert.True(parentType.GetClrType() == typeof(bool));
    }
}
