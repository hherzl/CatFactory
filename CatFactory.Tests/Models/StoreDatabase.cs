using CatFactory.ObjectRelationalMapping;

namespace CatFactory.Tests.Models
{
    public static class StoreDatabase
    {
        public static Database Mock
            => new Database
            {
                Name = "Store",
                DefaultSchema = "dbo",
                DatabaseTypeMaps = DatabaseTypeMapList.Default,
                Tables =
                {
                    new Table
                    {
                        Schema = "dbo",
                        Name = "EventLog",
                        Columns =
                        {
                            new Column { Name = "EventLogID", Type = "int" },
                            new Column { Name = "EventType", Type = "int" },
                            new Column { Name = "Key", Type = "varchar", Length = 255 },
                            new Column { Name = "Message", Type = "varchar" },
                            new Column { Name = "EntryDate", Type = "datetime" }
                        },
                        Identity = new Identity("EventLogID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "HumanResources",
                        Name = "Employee",
                        Columns =
                        {
                            new Column { Name = "EmployeeID", Type = "int" },
                            new Column { Name = "FirstName", Type = "varchar", Length = 25 },
                            new Column { Name = "MiddleName", Type = "varchar", Length = 25, Nullable = true },
                            new Column { Name = "LastName", Type = "varchar", Length = 25 },
                            new Column { Name = "BirthDate", Type = "datetime" }
                        },
                        Identity = new Identity("EmployeeID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "Production",
                        Name = "ProductCategory",
                        Columns =
                        {
                            new Column { Name = "ProductCategoryID", Type = "int" },
                            new Column { Name = "ProductCategoryName", Type = "varchar", Length = 100 },
                        },
                        Identity = new Identity("ProductCategoryID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "Production",
                        Name = "Product",
                        Columns =
                        {
                            new Column { Name = "ProductID", Type = "int" },
                            new Column { Name = "ProductName", Type = "varchar", Length = 100 },
                            new Column { Name = "ProductCategoryID", Type = "int" },
                            new Column { Name = "Description", Type = "varchar", Length = 255, Nullable = true }
                        },
                        Identity = new Identity("ProductID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "Production",
                        Name = "ProductInventory",
                        Columns =
                        {
                            new Column { Name = "ProductInventoryID", Type = "int" },
                            new Column { Name = "ProductID", Type = "int" },
                            new Column { Name = "EntryDate", Type = "datetime" },
                            new Column { Name = "Quantity", Type = "int" }
                        },
                        Identity = new Identity("ProductInventoryID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "Sales",
                        Name = "Customer",
                        Columns =
                        {
                            new Column { Name = "CustomerID", Type = "int" },
                            new Column { Name = "CompanyName", Type = "varchar", Length = 100, Nullable = true },
                            new Column { Name = "ContactName", Type = "varchar", Length = 100, Nullable = true }
                        },
                        Identity = new Identity("CustomerID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "Sales",
                        Name = "Shipper",
                        Columns =
                        {
                            new Column { Name = "ShipperID", Type = "int" },
                            new Column { Name = "CompanyName", Type = "varchar", Length = 100, Nullable = true },
                            new Column { Name = "ContactName", Type = "varchar", Length = 100, Nullable = true }
                        },
                        Identity = new Identity("ShipperID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "Sales",
                        Name = "Order",
                        Columns =
                        {
                            new Column { Name = "OrderID", Type = "bigint" },
                            new Column { Name = "OrderDate", Type = "datetime" },
                            new Column { Name = "CustomerID", Type = "int" },
                            new Column { Name = "EmployeeID", Type = "int" },
                            new Column { Name = "ShipperID", Type = "datetime" },
                            new Column { Name = "Comments", Type = "varchar", Length = 255, Nullable = true }
                        },
                        Identity = new Identity("OrderID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "Sales",
                        Name = "OrderDetail",
                        Columns =
                        {
                            new Column { Name = "OrderID", Type = "bigint" },
                            new Column { Name = "ProductID", Type = "int" },
                            new Column { Name = "ProductName", Type = "varchar", Length = 255 },
                            new Column { Name = "UnitPrice", Type = "decimal", Length = 8, Prec = 4 },
                            new Column { Name = "Quantity", Type = "int" },
                            new Column { Name = "Total", Type = "decimal", Length = 8, Prec = 4 }
                        },
                        PrimaryKey = new PrimaryKey("OrderID", "ProductID")
                    }
                },
                Views =
                {
                    new View
                    {
                        Schema = "Sales",
                        Name = "OrderSummary",
                        Columns =
                        {
                            new Column { Name = "OrderID", Type = "int" },
                            new Column { Name = "OrderDate", Type = "datetime" },
                            new Column { Name = "CustomerName", Type = "varchar", Length = 100 },
                            new Column { Name = "EmployeeName", Type = "varchar", Length = 100 },
                            new Column { Name = "ShipperName", Type = "varchar", Length = 100 },
                            new Column { Name = "OrderLines", Type = "int" }
                        }
                    }
                }
            }
            .AddDbObjectsFromTables()
            .AddDbObjectsFromViews()
            .SetPrimaryKeyForTables()
            .LinkTables();
    }
}
