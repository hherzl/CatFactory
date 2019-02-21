using CatFactory.ObjectRelationalMapping;
using CatFactory.Tests.Helpers;
using CatFactory.Tests.Models;
using Newtonsoft.Json;
using Xunit;

namespace CatFactory.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void SerializeMockDatabaseToXmlTest()
        {
            // Arrange
            var fileName = "C:\\Temp\\CatFactory\\OnlineStore.xml";
            var database = Databases.OnlineStore;
            var xml = XmlSerializerHelper.Serialize(database);

            // Act
            TextFileHelper.CreateFile(fileName, xml);

            var deserializedDatabase = XmlSerializerHelper.DeserializeFrom<Database>(fileName);

            // Assert
            Assert.True(database.Name == deserializedDatabase.Name);
            Assert.True(database.Tables.Count == deserializedDatabase.Tables.Count);
            Assert.True(database.FindTable("Sales.OrderHeader").FullName == deserializedDatabase.FindTable("Sales.OrderHeader").FullName);
            Assert.True(database.Views.Count == deserializedDatabase.Views.Count);
        }

        [Fact]
        public void SerializeMockDatabaseToJsonTest()
        {
            // Arrange
            var database = Databases.OnlineStore;
            var fileName = "C:\\Temp\\CatFactory\\OnlineStore.json";

            // Act
            var json = JsonConvert.SerializeObject(database);

            System.IO.File.WriteAllText(fileName, json);

            var deserializedDatabase = JsonConvert.DeserializeObject<Database>(json);

            // Assert
            Assert.True(database.Name == deserializedDatabase.Name);
            Assert.True(database.Tables.Count == deserializedDatabase.Tables.Count);
            Assert.True(database.FindTable("Sales.OrderHeader").FullName == deserializedDatabase.FindTable("Sales.OrderHeader").FullName);
            Assert.True(database.Views.Count == deserializedDatabase.Views.Count);
        }
    }
}
