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
            var classDefinition = new ClassDefinition();

            classDefinition.Documentation.Summary = "Represents a simple class definition";

            classDefinition.Properties.Add(new PropertyDefinition { Type = "Int32?", Name = "ID" });
            classDefinition.Properties.Add(new PropertyDefinition { Type = "String", Name = "Name" });
            classDefinition.Properties.Add(new PropertyDefinition { Type = "String", Name = "Description" });
        }

        [Fact]
        public void TestEntityWithDataAnnotationsDefinition()
        {
            var classDefinition = new ClassDefinition();

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
            var classDefinition = new ClassDefinition();

            classDefinition.Namespaces.Add("System.ComponentModel");

            classDefinition.Implements.Add("INotifyPropertyChanged");

            classDefinition.Events.Add(new EventDefinition("PropertyChangedEventHandler", "PropertyChanged"));

            classDefinition.Fields.Add(new FieldDefinition("String", "m_firstName"));

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
