using CatFactory.ObjectRelationalMapping;

namespace CatFactory.Tests.Models
{
    public static class SupermarketDatabase
    {
        public static Database Mock
            => new Database
            {
                Name = "Supermarket",
                DefaultSchema = "dbo",
                DatabaseTypeMaps = DatabaseTypeMapList.Default,
                Tables =
                {
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
                            new Column { Name = "", Type = "varchar", Length = 255, Nullable = true }
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
                        Identity = new Identity("Shipper ID", 1, 1)
                    }
                }
            }
            .AddDbObjectsFromTables()
            .SetPrimaryKeyForTables()
            .LinkTables();
    }
}
