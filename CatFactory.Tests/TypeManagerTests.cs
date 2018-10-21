using CatFactory.ObjectOrientedProgramming;
using Xunit;

namespace CatFactory.Tests
{
    public class TypeManagerTests
    {
        [Fact]
        public void TestCheckIfClassExists()
        {
            // Arrange
            var definition = new ClassDefinition
            {
                Namespace = "Store",
                Name = "Product"
            };

            // Act
            var obj = TypeManager.GetItemByFullName("Store.Product");

            // Assert
            Assert.False(obj == null);
            Assert.True(obj is ClassDefinition);
        }

        [Fact]
        public void TestGetNonExistingClass()
        {
            // Arrange

            // Act
            var obj = TypeManager.GetItemByFullName("Store.Foo");

            // Assert
            Assert.True(obj == null);
        }

        [Fact]
        public void TestCheckIfInterfaceExists()
        {
            // Arrange
            var definition = new InterfaceDefinition
            {
                Namespace = "Store",
                Name = "ISalesRepository"
            };

            // Act
            var obj = TypeManager.GetItemByFullName("Store.ISalesRepository");

            // Assert
            Assert.False(obj == null);
            Assert.True(obj is InterfaceDefinition);
        }

        [Fact]
        public void TestGetNonExistingInterface()
        {
            // Arrange

            // Act
            var obj = TypeManager.GetItemByFullName("Store.IRepository");

            // Assert
            Assert.True(obj == null);
        }
    }
}
