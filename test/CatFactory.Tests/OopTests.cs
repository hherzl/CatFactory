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
                Name = "Person"
            };

            classDefinition.Attributes.Add(new MetadataAttribute("Table", "\"Person\"")
            {
                Sets = new List<MetadataAttributeSet>()
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
                Name = "PersonViewModel"
            };

            classDefinition.Namespaces.Add("System.ComponentModel");

            classDefinition.Implements.Add("INotifyPropertyChanged");

            classDefinition.Events.Add(new EventDefinition("PropertyChangedEventHandler", "PropertyChanged"));

            classDefinition.Fields.Add(new FieldDefinition(AccessModifier.Private, "String", "m_firstName"));

            classDefinition.Properties.Add(new PropertyDefinition("String", "FirstName")
            {
                GetBody = new List<CodeLine>()
                {
                    new CodeLine("return m_firstName;")
                },
                SetBody = new List<CodeLine>()
                {
                    new CodeLine("if (m_firstName != value)"),
                    new CodeLine("{{"),
                    new CodeLine("m_firstName = value;"),
                    new CodeLine(),
                    new CodeLine("PropertyChanged?Invoke(this, new PropertyChangedEventArgs(\"FirstName\"));"),
                    new CodeLine("}}")
                }
            });
        }
    }
}
