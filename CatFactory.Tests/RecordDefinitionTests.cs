using System;
using CatFactory.ObjectOrientedProgramming;
using Xunit;

namespace CatFactory.Tests
{
    public class RecordDefinitionTests
    {
        [Fact]
        public void Test_RecordDefinition()
        {
            // Arrange
            var definition = new RecordDefinition
            {
                Documentation = new Documentation
                {
                    Summary = "Represents a simple record definition for employee"
                },
                AccessModifier = AccessModifier.Public,
                Name = "Employee",
                Properties =
                {
                    new PropertyDefinition(AccessModifier.Public, "int?", "Id"),
                    new PropertyDefinition(AccessModifier.Public, "string", "GivenName"),
                    new PropertyDefinition(AccessModifier.Public, "string", "MiddleName"),
                    new PropertyDefinition(AccessModifier.Public, "string", "FamilyName")
                }
            };

            // Act

            // Assert
            Assert.True(definition.AccessModifier == AccessModifier.Public);
            Assert.True(definition.Properties[0].AccessModifier == AccessModifier.Public);
            Assert.True(definition.Properties[1].AccessModifier == AccessModifier.Public);
            Assert.True(definition.Properties[2].AccessModifier == AccessModifier.Public);
            Assert.True(definition.Properties[3].AccessModifier == AccessModifier.Public);
        }

        [Fact]
        public void Test_ConvertClassToRecord()
        {
            // Arrange
            var classDefinition = new ClassDefinition
            {
                Namespaces =
                {
                    "System"
                },
                AccessModifier = AccessModifier.Public,
                Name = "Member"
            };

            classDefinition.AddAutomaticProperty("short?", "Id");
            classDefinition.AddAutomaticProperty("string", "Name");
            classDefinition.AddAutomaticProperty("string", "Phone");
            classDefinition.AddAutomaticProperty("string", "Email");
            classDefinition.AddAutomaticProperty("DateTime", "SignDate");

            // Act
            var recordDefinition = classDefinition.ToRecordDefinition();

            // Assert
            Assert.True(recordDefinition.AccessModifier == classDefinition.AccessModifier);
            Assert.True(recordDefinition.FullName == classDefinition.FullName);
            Assert.True(recordDefinition.Properties.Count == classDefinition.Properties.Count);
            Assert.True(recordDefinition.Fields.Count == 0);
        }

        [Fact]
        public void Test_ConvertClassToRecordWithConvertOptions()
        {
            // Arrange
            var classDefinition = new ClassDefinition
            {
                AccessModifier = AccessModifier.Public,
                Name = "StockItem"
            };

            classDefinition.AddAutomaticProperty("Guid", "Id");
            classDefinition.AddAutomaticProperty("string", "Name");
            classDefinition.AddAutomaticProperty("string", "SKU");
            classDefinition.AddAutomaticProperty("decimal", "UnitPrice");
            classDefinition.AddAutomaticProperty("DateTime?", "ReleaseDate");

            classDefinition.Fields.Add(new FieldDefinition("bool", "Flag"));

            var convertOptions = new ConvertOptions(includeFields: true);

            // Act
            var recordDefinition = classDefinition.ToRecordDefinition(convertOptions);

            // Assert
            Assert.True(recordDefinition.AccessModifier == classDefinition.AccessModifier);
            Assert.True(recordDefinition.FullName == classDefinition.FullName);
            Assert.True(recordDefinition.Fields.Count == classDefinition.Fields.Count);
            Assert.True(recordDefinition.Properties.Count == classDefinition.Properties.Count);
        }

        [Fact]
        public void Test_RefactRecordDefinitionFromAnonymous()
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
            var recordDefinition = anonymousDefinition.RefactRecordDefinition("StockItem");

            // Assert
            Assert.True(string.IsNullOrEmpty(recordDefinition.Namespace));
            Assert.True(recordDefinition.Name == "StockItem");
            Assert.True(recordDefinition.Properties.Count == 4);
        }
    }
}
