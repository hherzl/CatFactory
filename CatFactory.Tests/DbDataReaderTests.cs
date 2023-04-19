using System.Data;
using System.Threading.Tasks;
using CatFactory.ObjectOrientedProgramming;
using Microsoft.Data.SqlClient;
using Xunit;

namespace CatFactory.Tests
{
    public class DbDataReaderTests
    {
        private const string ConnectionString = "server=(local); database=master; integrated security=yes; TrustServerCertificate=True;";

        [Fact]
        public async Task TestGetClassDefinitionFromDbDataReaderAsync()
        {
            using var connection = new SqlConnection(ConnectionString);

            await connection.OpenAsync();

            using var command = connection.CreateCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = " select top 1 * from sys.tables ";

            using var dataReader = await command.ExecuteReaderAsync();

            var classDefinition = dataReader.GetClassDefinition();

            Assert.True(classDefinition.Properties.Count > 0);
        }

        [Fact]
        public async Task TestGetRecordDefinitionFromDbDataReaderAsync()
        {
            using var connection = new SqlConnection(ConnectionString);

            await connection.OpenAsync();

            using var command = connection.CreateCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = " select top 1 * from sys.tables ";

            using var dataReader = await command.ExecuteReaderAsync();

            var recordDefinition = dataReader.GetRecordDefinition();

            Assert.True(recordDefinition.Properties.Count > 0);
        }
    }
}
