using System;
using CatFactory.CodeFactory;
using CatFactory.ObjectOrientedProgramming;
using Xunit;

namespace CatFactory.Tests;

public class ClassDefinitionTests
{
    [Fact]
    public void Test_ClassDefinition()
    {
        // Arrange
        var definition = new ClassDefinition
        {
            Namespaces =
            {
                "System"
            },
            Documentation = new Documentation
            {
                Summary = "Represents a simple class definition"
            },
            Name = "Product",
            Properties =
            {
                new PropertyDefinition(AccessModifier.Public, "int?", "Id"),
                new PropertyDefinition(AccessModifier.Public, "string", "Name"),
                new PropertyDefinition("string", "Description"),
                new PropertyDefinition("decimal?", "UnitPrice")
            }
        };

        // Act

        // Assert
        Assert.Equal(AccessModifier.Private, definition.AccessModifier);
        Assert.Equal(AccessModifier.Public, definition.Properties[0].AccessModifier);
        Assert.Equal(AccessModifier.Public, definition.Properties[1].AccessModifier);
        Assert.Equal(AccessModifier.Private, definition.Properties[2].AccessModifier);
        Assert.Equal(AccessModifier.Private, definition.Properties[3].AccessModifier);
    }

    [Fact]
    public void Test_EntityClassWithDataAnnotationsDefinition()
    {
        // Arrange
        var definition = new ClassDefinition
        {
            Namespaces =
            {
                "System"
            },
            Attributes =
            {
                new MetadataAttribute("Table", "\"Person\"")
                {
                    Sets =
                    {
                        new MetadataAttributeSet("Schema", "\"HumanResources\"")
                    }
                }
            },
            Name = "Person",
            Properties =
            {
                new PropertyDefinition("int?", "Id", new MetadataAttribute("Key")),
                new PropertyDefinition("string", "FirstName", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "25")),
                new PropertyDefinition("string", "MiddleName", new MetadataAttribute("StringLength", "25")),
                new PropertyDefinition("string", "LastName", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "25")),
                new PropertyDefinition("string", "Gender", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "1")),
                new PropertyDefinition("DateTime?", "BirthDate", new MetadataAttribute("Required"))
            }
        };

        // Act

        // Assert
        Assert.Equal(AccessModifier.Private, definition.AccessModifier);
        Assert.Equal(AccessModifier.Private, definition.Properties[0].AccessModifier);
    }

    [Fact]
    public void Test_ViewModelClassDefinition()
    {
        // Arrange
        var definition = new ClassDefinition
        {
            Namespaces =
            {
                "System",
                "System.ComponentModel"
            },
            Name = "PersonViewModel",
            Implements =
            {
                "INotifyPropertyChanged"
            },
            Events =
            {
                new EventDefinition("PropertyChangedEventHandler", "PropertyChanged")
            },
            Fields =
            {
                new FieldDefinition("string", "m_firstName")
            }
        };

        definition.Properties.Add(new PropertyDefinition(AccessModifier.Public, "string", "FirstName")
        {
            GetBody =
            {
                new CodeLine("return m_firstName;")
            },
            SetBody =
            {
                new CodeLine("if (m_firstName != value)"),
                new CodeLine("{"),
                new CodeLine(1, "m_firstName = value;"),
                new CodeLine(),
                new CodeLine(1, "PropertyChanged?Invoke(this, new PropertyChangedEventArgs(\"FirstName\"));"),
                new CodeLine("}")
            }
        });

        // Act

        // Assert
        Assert.Equal(AccessModifier.Private, definition.AccessModifier);
        Assert.Equal(AccessModifier.Private, definition.Events[0].AccessModifier);
        Assert.Equal(AccessModifier.Private, definition.Fields[0].AccessModifier);
        Assert.Equal(AccessModifier.Public, definition.Properties[0].AccessModifier);
    }

    [Fact]
    public void Test_Inheritance()
    {
        // Arrange
        var classDefinition = new ClassDefinition
        {
            Name = "OnlineStoreDbContext",
            BaseClass = "Microsoft.EntityFrameworkCore.DbContext"
        };

        var interfaceDefinition = new InterfaceDefinition
        {
            Name = "ISalesService",
            Implements =
            {
                "IService"
            }
        };

        var enumDefinition = new EnumDefinition
        {
            Name = "FlowStatus",
            BaseType = "int",
            Sets =
            {
                new NameValue("Created", "0"),
                new NameValue("Started", "10")
            }
        };

        // Act

        // Assert
        Assert.True(classDefinition.HasInheritance);
        Assert.NotNull(classDefinition.BaseClass);
        Assert.Empty(classDefinition.Implements);

        Assert.True(interfaceDefinition.HasInheritance);
        Assert.NotEmpty(interfaceDefinition.Implements);

        Assert.True(enumDefinition.HasInheritance);
    }

    [Fact]
    public void Test_ConvertRecordToClass()
    {
        // Arrange
        var recordDefinition = new RecordDefinition
        {
            Namespaces =
            {
                "System"
            },
            AccessModifier = AccessModifier.Public,
            Name = "Member"
        };

        recordDefinition.AddAutomaticProperty("short?", "Id");
        recordDefinition.AddAutomaticProperty("string", "Name");
        recordDefinition.AddAutomaticProperty("string", "Phone");
        recordDefinition.AddAutomaticProperty("string", "Email");
        recordDefinition.AddAutomaticProperty("DateTime", "SignDate");

        // Act
        var classDefinition = recordDefinition.ToClassDefinition();

        // Assert
        Assert.Equal(classDefinition.AccessModifier, recordDefinition.AccessModifier);
        Assert.True(classDefinition.FullName == recordDefinition.FullName);
        Assert.True(classDefinition.Properties.Count == recordDefinition.Properties.Count);
        Assert.Empty(classDefinition.Fields);
    }

    [Fact]
    public void Test_ConvertRecordToClassWithConvertOptions()
    {
        // Arrange
        var recordDefinition = new RecordDefinition
        {
            Namespaces =
            {
                "System"
            },
            AccessModifier = AccessModifier.Public,
            Name = "StockItem"
        };

        recordDefinition.AddAutomaticProperty("Guid", "Id");
        recordDefinition.AddAutomaticProperty("string", "Name");
        recordDefinition.AddAutomaticProperty("string", "SKU");
        recordDefinition.AddAutomaticProperty("decimal", "UnitPrice");
        recordDefinition.AddAutomaticProperty("DateTime?", "ReleaseDate");

        recordDefinition.Fields.Add(new FieldDefinition("bool", "Flag"));

        var convertOptions = new ConvertOptions(includeFields: true);

        // Act
        var classDefinition = recordDefinition.ToClassDefinition(convertOptions);

        // Assert
        Assert.Equal(classDefinition.AccessModifier, recordDefinition.AccessModifier);
        Assert.True(classDefinition.FullName == recordDefinition.FullName);
        Assert.True(classDefinition.Fields.Count == recordDefinition.Fields.Count);
        Assert.True(classDefinition.Properties.Count == recordDefinition.Properties.Count);
    }

    [Fact]
    public void Test_RefactClassDefinitionFromAnonymous()
    {
        // Arrange
        var anonymousDefinition = new
        {
            Id = Guid.Empty,
            Name = "",
            Price = 0m,
            ReleaseDate = DateTime.Now
        };

        // Act
        var classDefinition = anonymousDefinition.RefactClassDefinition("Product");

        // Assert
        Assert.True(string.IsNullOrEmpty(classDefinition.Namespace));
        Assert.Equal("Product", classDefinition.Name);
        Assert.Equal(4, classDefinition.Properties.Count);
    }
}
