using CatFactory.ObjectRelationalMapping;

namespace CatFactory.Tests.Models;

public static partial class Databases
{
    public static Database OnlineStore
        => new Database
        {
            Name = "OnlineStore",
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
                        new Column("EventLogId", "int"),
                        new Column("EventType", "int" ),
                        new Column("Key", "varchar", 255),
                        new Column("Message", "varchar"),
                        new Column("EntryDate", "datetime")
                    },
                    Identity = new("EventLogId")
                },
                new Table
                {
                    Schema = "HumanResources",
                    Name = "Employee",
                    Columns =
                    {
                        new Column("EmployeeId", "int"),
                        new Column("FirstName", "varchar", 25),
                        new Column("MiddleName", "varchar", 25, true),
                        new Column("LastName", "varchar", 25),
                        new Column("BirthDate", "datetime")
                    },
                    Identity = new("EmployeeId")
                },
                new Table
                {
                    Schema = "Warehouse",
                    Name = "ProductCategory",
                    Columns =
                    {
                        new Column("ProductCategoryId", "int"),
                        new Column("ProductCategoryName", "varchar", 100),
                    },
                    Identity = new("ProductCategoryId")
                },
                new Table
                {
                    Schema = "Warehouse",
                    Name = "Product",
                    Columns =
                    {
                        new Column("ProductId", "int"),
                        new Column("ProductName", "varchar", 100),
                        new Column("ProductCategoryId", "int"),
                        new Column("UnitPrice", "decimal", 8, 4),
                        new Column("Description", "varchar", 255, true)
                    },
                    Identity = new("ProductId")
                },
                new Table
                {
                    Schema = "Warehouse",
                    Name = "ProductInventory",
                    Columns =
                    {
                        new Column("ProductInventoryId", "int"),
                        new Column("ProductId", "int"),
                        new Column("EntryDate", "datetime"),
                        new Column("Quantity", "int")
                    },
                    Identity = new("ProductInventoryId")
                },
                new Table
                {
                    Schema = "Sales",
                    Name = "Customer",
                    Columns =
                    {
                        new Column("CustomerId", "int"),
                        new Column("CompanyName", "varchar", 100, true),
                        new Column("ContactName", "varchar", 100, true)
                    },
                    Identity = new("CustomerId", 1, 1)
                },
                new Table
                {
                    Schema = "Sales",
                    Name = "Shipper",
                    Columns =
                    {
                        new Column("ShipperId", "int"),
                        new Column("CompanyName", "varchar", 100, true),
                        new Column("ContactName", "varchar", 100, true)
                    },
                    Identity = new("ShipperId")
                },
                new Table
                {
                    Schema = "Sales",
                    Name = "OrderHeader",
                    Columns =
                    {
                        new Column("OrderHeaderId", "bigint"),
                        new Column("OrderDate", "datetime"),
                        new Column("EmployeeId", "int"),
                        new Column("CustomerId", "int"),
                        new Column("ShipperId", "datetime"),
                        new Column("Comments", "varchar", 255, true)
                    },
                    Identity = new("OrderHeaderID")
                },
                new Table
                {
                    Schema = "Sales",
                    Name = "OrderDetail",
                    Columns =
                    {
                        new Column("OrderHeaderId", "bigint"),
                        new Column("ProductId", "int"),
                        new Column("ProductName", "varchar", 255),
                        new Column("UnitPrice", "decimal", 8, 4),
                        new Column("Quantity", "int"),
                        new Column("Total", "decimal", 8, 4)
                    },
                    PrimaryKey = new("PK_Sales_OrderDetail", ["OrderHeaderId", "ProductId"])
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
                        new Column("OrderHeaderId", "bigint"),
                        new Column("OrderDate", "datetime"),
                        new Column("CustomerName", "varchar", 100),
                        new Column("EmployeeName", "varchar", 100),
                        new Column("ShipperName", "varchar", 100),
                        new Column("OrderLines", "int")
                    }
                }
            }
        }
        .AddDbObjectsFromTables()
        .AddDbObjectsFromViews()
        .SetPrimaryKeyForTables()
        .LinkTables();
}
