using CatFactory.CodeFactory;
using CatFactory.OOP;
using Xunit;

namespace CatFactory.Tests
{
    public class OopTests
    {
        [Fact]
        public void TestClassDefinition()
        {
            // Arrange
            var classDefinition = new ClassDefinition
            {
                Namespaces =
                {
                    "System"
                },
                Name = "Product"
            };

            classDefinition.Documentation.Summary = "Represents a simple class definition";

            classDefinition.Properties.Add(new PropertyDefinition("Int32?", "ID"));
            classDefinition.Properties.Add(new PropertyDefinition("String", "Name"));
            classDefinition.Properties.Add(new PropertyDefinition("String", "Description"));

            // Act
            // Assert
        }

        [Fact]
        public void TestEntityWithDataAnnotationsDefinition()
        {
            // Arrange
            var classDefinition = new ClassDefinition
            {
                Namespaces =
                {
                    "System"
                },
                Name = "Person"
            };

            classDefinition.Attributes.Add(new MetadataAttribute("Table", "\"Person\"")
            {
                Sets =
                {
                    new MetadataAttributeSet("Schema", "\"HumanResources\"")
                }
            });

            classDefinition.Properties.Add(new PropertyDefinition("Int32?", "ID", new MetadataAttribute("Key")));
            classDefinition.Properties.Add(new PropertyDefinition("String", "FirstName", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "25")));
            classDefinition.Properties.Add(new PropertyDefinition("String", "MiddleName", new MetadataAttribute("StringLength", "25")));
            classDefinition.Properties.Add(new PropertyDefinition("String", "LastName", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "25")));
            classDefinition.Properties.Add(new PropertyDefinition("String", "Gender", new MetadataAttribute("Required"), new MetadataAttribute("StringLength", "1")));
            classDefinition.Properties.Add(new PropertyDefinition("DateTime?", "BirthDate", new MetadataAttribute("Required")));

            // Act
            // Assert
        }

        [Fact]
        public void TestViewModelClassDefinition()
        {
            // Arrange
            var classDefinition = new ClassDefinition
            {
                Namespaces =
                {
                    "System",
                    "System.ComponentModel"
                },
                Name = "PersonViewModel"
            };

            classDefinition.Namespaces.Add("System.ComponentModel");

            classDefinition.Implements.Add("INotifyPropertyChanged");

            classDefinition.Events.Add(new EventDefinition("PropertyChangedEventHandler", "PropertyChanged"));

            classDefinition.Fields.Add(new FieldDefinition(AccessModifier.Private, "String", "m_firstName"));

            classDefinition.Properties.Add(new PropertyDefinition("String", "FirstName")
            {
                GetBody =
                {
                    new CodeLine("return m_firstName;")
                },
                SetBody =
                {
                    new CodeLine("if (m_firstName != value)"),
                    new CodeLine("{"),
                    new CodeLine("m_firstName = value;"),
                    new CodeLine(),
                    new CodeLine("PropertyChanged?Invoke(this, new PropertyChangedEventArgs(\"FirstName\"));"),
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
