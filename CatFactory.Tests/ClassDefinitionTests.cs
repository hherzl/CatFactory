using CatFactory.CodeFactory;
using CatFactory.ObjectOrientedProgramming;
using Xunit;

namespace CatFactory.Tests
{
    public class ClassDefinitionTests
    {
        [Fact]
        public void TestClassDefinition()
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
                    new PropertyDefinition("decimal?", "Description")
                }
            };

            // Act

            // Assert
            Assert.True(definition.AccessModifier == AccessModifier.Private);
            Assert.True(definition.Properties[0].AccessModifier == AccessModifier.Public);
            Assert.True(definition.Properties[1].AccessModifier == AccessModifier.Public);
            Assert.True(definition.Properties[2].AccessModifier == AccessModifier.Private);
            Assert.True(definition.Properties[3].AccessModifier == AccessModifier.Private);
        }

        [Fact]
        public void TestEntityClassWithDataAnnotationsDefinition()
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
            Assert.True(definition.AccessModifier == AccessModifier.Private);
            Assert.True(definition.Properties[0].AccessModifier == AccessModifier.Private);
        }

        [Fact]
        public void TestViewModelClassDefinition()
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
                    new FieldDefinition("String", "m_firstName")
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
            Assert.True(definition.AccessModifier == AccessModifier.Private);
            Assert.True(definition.Events[0].AccessModifier == AccessModifier.Private);
            Assert.True(definition.Fields[0].AccessModifier == AccessModifier.Private);
            Assert.True(definition.Properties[0].AccessModifier == AccessModifier.Public);
        }

        [Fact]
        public void TestInheritance()
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
            Assert.True(classDefinition.BaseClass != null);
            Assert.True(classDefinition.Implements.Count == 0);

            Assert.True(interfaceDefinition.HasInheritance);
            Assert.False(interfaceDefinition.Implements.Count == 0);

            Assert.True(enumDefinition.HasInheritance);
        }

        [Fact]
        public void TestConvertRecordToClass()
        {
            // Arrange
            var recordDefinition = new RecordDefinition
            {
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
            Assert.True(classDefinition.AccessModifier == recordDefinition.AccessModifier);
            Assert.True(classDefinition.FullName == recordDefinition.FullName);
            Assert.True(classDefinition.Properties.Count == recordDefinition.Properties.Count);
            Assert.True(classDefinition.Fields.Count == 0);
        }

        [Fact]
        public void TestConvertRecordToClassWithConvertOptions()
        {
            // Arrange
            var recordDefinition = new RecordDefinition
            {
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
            Assert.True(classDefinition.AccessModifier == recordDefinition.AccessModifier);
            Assert.True(classDefinition.FullName == recordDefinition.FullName);
            Assert.True(classDefinition.Fields.Count == recordDefinition.Fields.Count);
            Assert.True(classDefinition.Properties.Count == recordDefinition.Properties.Count);
        }
    }
}
