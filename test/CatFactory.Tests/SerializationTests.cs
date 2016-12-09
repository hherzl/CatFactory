using Xunit;

namespace CatFactory.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void SerializeMockDatabaseTest()
        {
            var db = Mocks.SalesDatabase;

            var serializer = new Serializer() as ISerializer;

            var output = serializer.Serialize(db);

            TextFileHelper.CreateFile("C:\\Temp\\Sales.xml", output);
        }
    }
}
