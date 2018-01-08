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
            var serializer = new Serializer() as ISerializer;
            var fileName = "C:\\Temp\\CatFactory\\Sales.xml";

            // Act
            var xml = serializer.Serialize(database);

            TextFileHelper.CreateFile(fileName, xml);

            var value = serializer.Deserialze<Database>(fileName);

            // Assert
            Assert.True(database.Name == value.Name);
        }
    }
}
