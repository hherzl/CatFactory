﻿using System.Data;
using System.Threading.Tasks;
using CatFactory.ObjectOrientedProgramming;
using Microsoft.Data.SqlClient;
using Xunit;

namespace CatFactory.Tests
{
    public class DbDataReaderTests
    {
        [Fact]
        public async Task TestGetClassDefinitionFromDbDataReaderAsync()
        {
            using var connection = new SqlConnection("server=(local); database=master; integrated security=yes; TrustServerCertificate=True;");

            await connection.OpenAsync();

            using var command = connection.CreateCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = " select top 1 * from sys.tables ";

            using var dataReader = await command.ExecuteReaderAsync();

            var classDefinition = dataReader.GetClassDefinition();

            Assert.True(classDefinition.Properties.Count > 0);
        }
    }
}
