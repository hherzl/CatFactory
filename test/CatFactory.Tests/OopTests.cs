using System;
using System.Collections.Generic;
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

            classDefinition.Properties.Add(new PropertyDefinition { Type = "Int32?", Name = "ID" });
            classDefinition.Properties.Add(new PropertyDefinition { Type = "String", Name = "Name" });
            classDefinition.Properties.Add(new PropertyDefinition { Type = "String", Name = "Description" });
        }

        [Fact]
        public void TestEntityWithDataAnnotationsDefinition()
        {
            var classDefinition = new ClassDefinition();

            classDefinition.Properties.Add(new PropertyDefinition
            {
                Type = "Int32?",
                Name = "ID",
                Attributes = new List<MetadataAttribute>()
                {
                    new MetadataAttribute("Key")
                }
            });

            classDefinition.Properties.Add(new PropertyDefinition
            {
                Type = "String",
                Name = "FirstName",
                Attributes = new List<MetadataAttribute>()
                {
                    new MetadataAttribute("Required"),
                    new MetadataAttribute("StringLength") { Arguments = new List<String>() { "25" } }
                }
            });

            classDefinition.Properties.Add(new PropertyDefinition
            {
                Type = "String",
                Name = "MiddleName",
                Attributes = new List<MetadataAttribute>()
                {
                    new MetadataAttribute("StringLength") { Arguments = new List<String>() { "25" } }
                }
            });

            classDefinition.Properties.Add(new PropertyDefinition
            {
                Type = "String",
                Name = "LastName",
                Attributes = new List<MetadataAttribute>()
                {
                    new MetadataAttribute("Required"),
                    new MetadataAttribute("StringLength") { Arguments = new List<String>() { "25" } }
                }
            });

            classDefinition.Properties.Add(new PropertyDefinition
            {
                Type = "String",
                Name = "Gender",
                Attributes = new List<MetadataAttribute>()
                {
                    new MetadataAttribute("Required"),
                    new MetadataAttribute("StringLength") { Arguments = new List<String>() { "1" } }
                }
            });

            classDefinition.Properties.Add(new PropertyDefinition
            {
                Type = "DateTime?",
                Name = "BirthDate",
                Attributes = new List<MetadataAttribute>()
                {
                    new MetadataAttribute("Required")
                }
            });
        }
    }
}
