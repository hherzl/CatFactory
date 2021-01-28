using System.IO;
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
            var fileName = @"C:\Temp\CatFactory\OnlineStore.xml";
            var db = Databases.OnlineStore;
            var xml = XmlSerializerHelper.Serialize(db);

            // Act
            TextFileHelper.CreateFile(fileName, xml);

            var deserializedDb = XmlSerializerHelper.DeserializeFrom<Database>(fileName);

            // Assert
            Assert.True(db.Name == deserializedDb.Name);
            Assert.True(db.Tables.Count == deserializedDb.Tables.Count);
            Assert.True(db.FindTable("Sales.OrderHeader").FullName == deserializedDb.FindTable("Sales.OrderHeader").FullName);
            Assert.True(db.Views.Count == deserializedDb.Views.Count);
        }

        [Fact]
        public void SerializeMockDatabaseToJsonTest()
        {
            // Arrange
            var db = Databases.OnlineStore;
            var fileName = @"C:\Temp\CatFactory\OnlineStore.json";

            // Act
            var json = JsonConvert.SerializeObject(db);

            File.WriteAllText(fileName, json);

            var deserializedDb = JsonConvert.DeserializeObject<Database>(json);

            // Assert
            Assert.True(db.Name == deserializedDb.Name);
            Assert.True(db.Tables.Count == deserializedDb.Tables.Count);
            Assert.True(db.FindTable("Sales.OrderHeader").FullName == deserializedDb.FindTable("Sales.OrderHeader").FullName);
            Assert.True(db.Views.Count == deserializedDb.Views.Count);
        }
    }
}
