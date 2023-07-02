using System;
using CatFactory.ObjectOrientedProgramming;
using Xunit;

namespace CatFactory.Tests
{
    public class InterfaceDefinitionTests
    {
        [Fact]
        public void Test_InterfaceDefinition()
        {
            // Arrange
            var definition = new InterfaceDefinition
            {
                Documentation = new Documentation
                {
                    Summary = "Represents a simple contract"
                },
                Name = "IStockItem",
                Properties =
                {
                    new PropertyDefinition("int?", "Id"),
                    new PropertyDefinition("string", "Name"),
                    new PropertyDefinition("string", "Description"),
                    new PropertyDefinition("decimal?", "UnitPrice")
                }
            };

            // Act

            // Assert
            Assert.True(definition.AccessModifier == AccessModifier.Private);
            Assert.True(definition.Properties.Count == 4);
        }

        [Fact]
        public void Test_RefactInterfaceDefinitionFromAnonymous()
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
            var interfaceDefinition = anonymousDefinition.RefactInterfaceDefinition("StockItem");

            // Assert
            Assert.True(string.IsNullOrEmpty(interfaceDefinition.Namespace));
            Assert.True(interfaceDefinition.Name == "StockItem");
            Assert.True(interfaceDefinition.Properties.Count == 4);
        }
    }
}
