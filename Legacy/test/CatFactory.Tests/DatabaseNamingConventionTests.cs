using System.Collections.Generic;
using CatFactory.Mapping;
using Xunit;

namespace CatFactory.Tests
{
    public class DatabaseNamingConventionTests
    {
        [Fact]
        public void TestConstraintNames()
        {
            // Arrange
            var database = new Database();

            var productCategoryTable = new Table
            {
                Schema = "dbo",
                Name = "ProductCategory",
                Columns = new List<Column>()
                {
                    new Column
                    {
                        Name = "ProductCategoryID",
                        Type = "int",
                        Nullable = false
                    },
                    new Column
                    {
                        Name = "ProductCategoryName",
                        Type = "varchar",
                        Length = 100,
                        Nullable = false
                    }
                }
            };

            database.Tables.Add(productCategoryTable);

            var productTable = new Table
            {
                Schema = "dbo",
                Name = "Product",
                Columns = new List<Column>()
                {
                    new Column
                    {
                        Name = "ProductID",
                        Type = "int",
                        Nullable = false
                    },
                    new Column
                    {
                        Name = "ProductName",
                        Type = "varchar",
                        Length = 100,
                        Nullable = false
                    },
                    new Column
                    {
                        Name = "ProductCategoryID",
                        Type = "int",
                        Nullable = false
                    }
                }
            };

            database.Tables.Add(productTable);

            // Act
            var primaryKeyName = database.NamingConvention.GetPrimaryKeyConstraintName(productTable, new string[] { "ProductID" });
            var foreignKeyName = database.NamingConvention.GetForeignKeyConstraintName(productTable, new string[] { "ProductCategoryID" }, productCategoryTable);
            var uniqueName = database.NamingConvention.GetUniqueConstraintName(productTable, new string[] { "ProductName" });

            // Assert
            Assert.True(primaryKeyName == "PK_dbo_Product");
            Assert.True(foreignKeyName == "FK_dbo_Product_ProductCategoryID_dbo_ProductCategory");
            Assert.True(uniqueName == "U_dbo_Product_ProductName");
        }
    }
}
