using System.Collections.Generic;
using CatFactory.CodeFactory;
using CatFactory.OOP;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void TestClassDefinition()
        {
            var classDefinition = new ClassDefinition
            {
                Namespaces = new List<string>
                {
                    "System"
                },
                Name = "Product"
            };

            classDefinition.Documentation.Summary = "Represents a simple class definition";

            classDefinition.Properties.Add(new PropertyDefinition("Int32?", "ID"));
            classDefinition.Properties.Add(new PropertyDefinition("String", "Name"));
            classDefinition.Properties.Add(new PropertyDefinition("String", "Description"));
        }

        [Fact]
        public void TestEntityWithDataAnnotationsDefinition()
        {
            var classDefinition = new ClassDefinition
            {
                Namespaces = new List<string>
                {
                    "System"
                },
                Name = "Person"
            };

            classDefinition.Attributes.Add(new MetadataAttribute("Table", "\"Person\"")
            {
                Sets = new List<MetadataAttributeSet>
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
        }

        [Fact]
        public void TestViewModelClassDefinition()
        {
            var classDefinition = new ClassDefinition
            {
                Namespaces = new List<string>
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
                GetBody = new List<ILine>
                {
                    new CodeLine("return m_firstName;")
                },
                SetBody = new List<ILine>
                {
                    new CodeLine("if (m_firstName != value)"),
                    new CodeLine("{"),
                    new CodeLine("m_firstName = value;"),
                    new CodeLine(),
                    new CodeLine("PropertyChanged?Invoke(this, new PropertyChangedEventArgs(\"FirstName\"));"),
                    new CodeLine("}")
                }
            });
        }

        [Fact]
        public void TestInheritance()
        {
            var dbContextClassDefinition = new ClassDefinition
            {
                Name = "StoreDbContext",
                BaseClass = "Microsoft.EntityFrameworkCore.DbContext"
            };

            var repositoryInterfaceDefinition = new InterfaceDefinition
            {
                Name = "ISalesRepository",
                Implements = new List<string>
                {
                    "IRepository"
                }
            };

            var savingTypeEnum = new EnumDefinition
            {
                Name = "SavingType",
                BaseType = "int"
            };

            Assert.True(dbContextClassDefinition.HasInheritance);
            Assert.True(dbContextClassDefinition.BaseClass != null);
            Assert.True(dbContextClassDefinition.Implements.Count == 0);

            Assert.True(repositoryInterfaceDefinition.HasInheritance);
            Assert.False(repositoryInterfaceDefinition.Implements.Count == 0);

            Assert.True(savingTypeEnum.HasInheritance);
        }
    }
}
