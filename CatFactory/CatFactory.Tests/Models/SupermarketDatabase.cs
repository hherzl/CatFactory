using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory.Tests.Models
{
    public static class SupermarketDatabase
    {
        public static Database Mock
            => new Database
            {
                Name = "Supermarket",
                Tables = new List<Table>
                {
                    new Table
                    {
                        Schema = "HumanResources",
                        Name = "Employee",
                        Columns = new List<Column>
                        {
                            new Column { Name = "EmployeeID", Type = "int" },
                            new Column { Name = "FirstName", Type = "varchar", Length = 25 },
                            new Column { Name = "MiddleName", Type = "varchar", Length = 25, Nullable = true },
                            new Column { Name = "LastName", Type = "varchar", Length = 25 },
                            new Column { Name = "BirthDate", Type = "datetime" }
                        },
                        Identity = new Identity { Name = "EmployeeID", Seed = 1, Increment = 1 }
                    },
                    new Table
                    {
                        Schema = "Production",
                        Name = "ProductCategory",
                        Columns = new List<Column>
                        {
                            new Column { Name = "ProductCategoryID", Type = "int" },
                            new Column { Name = "ProductCategoryName", Type = "varchar", Length = 100 },
                        },
                        Identity = new Identity { Name = "ProductCategoryID", Seed = 1, Increment = 1 }
                    },
                    new Table
                    {
                        Schema = "Production",
                        Name = "Product",
                        Columns = new List<Column>
                        {
                            new Column { Name = "ProductID", Type = "int" },
                            new Column { Name = "ProductName", Type = "varchar", Length = 100 },
                            new Column { Name = "ProductCategoryID", Type = "int" },
                            new Column { Name = "", Type = "varchar", Length = 255, Nullable = true }
                        },
                        Identity = new Identity { Name = "ProductID", Seed = 1, Increment = 1 }
                    },
                    new Table
                    {
                        Schema = "Production",
                        Name = "ProductInventory",
                        Columns = new List<Column>
                        {
                            new Column { Name = "ProductInventoryID", Type = "int" },
                            new Column { Name = "ProductID", Type = "int" },
                            new Column { Name = "ProductID", Type = "int" },
                            new Column { Name = "EntryDate", Type = "datetime" },
                            new Column { Name = "Quantity", Type = "int" }
                        },
                        Identity = new Identity { Name = "ProductInventoryID", Seed = 1, Increment = 1 }
                    },
                    new Table
                    {
                        Schema = "Sales",
                        Name = "Customer",
                        Columns = new List<Column>
                        {
                            new Column { Name = "CustomerID", Type = "int" },
                            new Column { Name = "CompanyName", Type = "varchar", Length = 100, Nullable = true },
                            new Column { Name = "ContactName", Type = "varchar", Length = 100, Nullable = true }
                        },
                        Identity = new Identity { Name = "CustomerID", Seed = 1, Increment = 1 }
                    },
                    new Table
                    {
                        Schema = "Sales",
                        Name = "Shipper",
                        Columns = new List<Column>
                        {
                            new Column { Name = "ShipperID", Type = "int" },
                            new Column { Name = "CompanyName", Type = "varchar", Length = 100, Nullable = true },
                            new Column { Name = "ContactName", Type = "varchar", Length = 100, Nullable = true }
                        },
                        Identity = new Identity { Name = "Shipper ID", Seed = 1, Increment = 1 }
                    }
                }
            }
            .AddDbObjectsFromTables()
            .AddDbObjectsFromViews()
            .SetPrimaryKeyToTables()
            .SetMappings(DatabaseTypeMapList.Definition)
            .LinkTables();
    }
}
