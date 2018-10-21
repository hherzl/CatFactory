using CatFactory.CodeFactory;
using CatFactory.ObjectOrientedProgramming;
using Xunit;

namespace CatFactory.Tests
{
    public class ObjectOrientedProgrammingTests
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
                    new PropertyDefinition("Int32?", "ID"),
                    new PropertyDefinition("String", "Name"),
                    new PropertyDefinition("String", "Description")
                }
            };

            // Act
            // Assert
        }

        [Fact]
        public void TestEntityWithDataAnnotationsDefinition()
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
                    new PropertyDefinition("Int32?", "ID", new MetadataAttribute("Key")),
                    new PropertyDefinition("String", "FirstName", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "25")),
                    new PropertyDefinition("String", "MiddleName", new MetadataAttribute("StringLength", "25")),
                    new PropertyDefinition("String", "LastName", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "25")),
                    new PropertyDefinition("String", "Gender", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "1")),
                    new PropertyDefinition("DateTime?", "BirthDate", new MetadataAttribute("Required"))
                }
            };

            // Act
            // Assert
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
                    "System.ComponentModel",
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
                    new FieldDefinition(AccessModifier.Private, "String", "m_firstName")
                }
            };

            definition.Properties.Add(new PropertyDefinition("String", "FirstName")
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
        }

        [Fact]
        public void TestInheritance()
        {
            // Arrange
            var dbContextClassDefinition = new ClassDefinition
            {
                Name = "StoreDbContext",
                BaseClass = "Microsoft.EntityFrameworkCore.DbContext"
            };

            var repositoryInterfaceDefinition = new InterfaceDefinition
            {
                Name = "ISalesRepository",
                Implements =
                {
                    "IRepository"
                }
            };

            var savingTypeEnum = new EnumDefinition
            {
                Name = "SavingType",
                BaseType = "int"
            };

            // Act

            // Assert
            Assert.True(dbContextClassDefinition.HasInheritance);
            Assert.True(dbContextClassDefinition.BaseClass != null);
            Assert.True(dbContextClassDefinition.Implements.Count == 0);

            Assert.True(repositoryInterfaceDefinition.HasInheritance);
            Assert.False(repositoryInterfaceDefinition.Implements.Count == 0);

            Assert.True(savingTypeEnum.HasInheritance);
        }
    }
}
