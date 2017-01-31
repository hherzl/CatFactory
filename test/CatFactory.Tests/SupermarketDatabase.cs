using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory.Tests
{
    public static class SupermarketDatabase
    {
        public static Database Mock
        {
            get
            {
                var db = new Database()
                {
                    Name = "Supermarket",
                    Tables = new List<Table>()
                    {
                        new Table
                        {
                            Schema = "HumanResources",
                            Name = "Employee",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "EmployeeID", Type = "int", Nullable = false },
                                new Column { Name = "FirstName", Type = "varchar", Length = 25, Nullable = false },
                                new Column { Name = "MiddleName", Type = "varchar", Length = 25, Nullable = true },
                                new Column { Name = "LastName", Type = "varchar", Length = 25, Nullable = false },
                                new Column { Name = "BirthDate", Type = "datetime", Nullable = false }
                            },
                            Identity = new Identity { Name = "EmployeeID", Seed = 1, Increment = 1 }
                        },
                        new Table
                        {
                            Schema = "Production",
                            Name = "ProductCategory",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "ProductCategoryID", Type = "int", Nullable = false },
                                new Column { Name = "ProductCategoryName", Type = "varchar", Length = 100, Nullable = false },
                            },
                            Identity = new Identity { Name = "ProductCategoryID", Seed = 1, Increment = 1 }
                        },
                        new Table
                        {
                            Schema = "Production",
                            Name = "Product",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "ProductID", Type = "int", Nullable = false },
                                new Column { Name = "ProductName", Type = "varchar", Length = 100, Nullable = false },
                                new Column { Name = "ProductCategoryID", Type = "int", Nullable = false },
                                new Column { Name = "", Type = "varchar", Length = 255, Nullable = true }
                            },
                            Identity = new Identity { Name = "ProductID", Seed = 1, Increment = 1 }
                        },
                        new Table
                        {
                            Schema = "Production",
                            Name = "ProductInventory",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "ProductInventoryID", Type = "int", Nullable = false },
                                new Column { Name = "ProductID", Type = "int", Nullable = false },
                                new Column { Name = "ProductID", Type = "int", Nullable = false },
                                new Column { Name = "EntryDate", Type = "datetime", Nullable = false },
                                new Column { Name = "Quantity", Type = "int", Nullable = false }
                            },
                            Identity = new Identity { Name = "ProductInventoryID", Seed = 1, Increment = 1 }
                        },
                        new Table
                        {
                            Schema = "Sales",
                            Name = "Customer",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "CustomerID", Type = "int", Nullable = false },
                                new Column { Name = "CompanyName", Type = "varchar", Length = 100, Nullable = true },
                                new Column { Name = "ContactName", Type = "varchar", Length = 100, Nullable = true }
                            },
                            Identity = new Identity { Name = "CustomerID", Seed = 1, Increment = 1 }
                        },
                        new Table
                        {
                            Schema = "Sales",
                            Name = "Shipper",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "ShipperID", Type = "int", Nullable = false },
                                new Column { Name = "CompanyName", Type = "varchar", Length = 100, Nullable = true },
                                new Column { Name = "ContactName", Type = "varchar", Length = 100, Nullable = true }
                            },
                            Identity = new Identity { Name = "Shipper ID", Seed = 1, Increment = 1 }
                        }
                    }
                };

                db.AddPrimaryKeyToTables();

                db.LinkTables();

                return db;
            }
        }
    }
}
