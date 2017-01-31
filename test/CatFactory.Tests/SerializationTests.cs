using Xunit;

namespace CatFactory.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void SerializeMockDatabaseTest()
        {
            var db = StoreDatabase.Mock;

            var serializer = new Serializer() as ISerializer;

            var output = serializer.Serialize(db);

            TextFileHelper.CreateFile("C:\\Temp\\CatFactory\\Sales.xml", output);
        }
    }
}
