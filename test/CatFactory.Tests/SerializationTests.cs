using CatFactory.Mapping;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void SerializeMockDatabaseTest()
        {
            // Arrange
            var database = StoreDatabase.Mock;
            var fileName = "C:\\Temp\\CatFactory\\Sales.xml";

            // Act
            var xml = XmlSerializerHelper.Serialize(database);

            TextFileHelper.CreateFile(fileName, xml);

            var value = XmlSerializerHelper.Deserialze<Database>(fileName);

            // Assert
            Assert.True(database.Name == value.Name);
        }
    }
}
