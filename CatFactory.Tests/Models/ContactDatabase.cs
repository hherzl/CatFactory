using CatFactory.Mapping;

namespace CatFactory.Tests.Models
{
    public static class ContactDatabase
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
                        Name = "ContactType",
                        Columns =
                        {
                            new Column { Name = "ContactTypeID", Type = "int" },
                            new Column { Name = "Description", Type = "varchar", Length = 50 }
                        },
                        Identity = new Identity("ContactTypeID", 100, 100)
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "Contact",
                        Columns =
                        {
                            new Column { Name = "ContactID", Type = "int" },
                            new Column { Name = "ContactTypeID", Type = "int" },
                            new Column { Name = "FirstName", Type = "varchar", Length = 25 },
                            new Column { Name = "MiddleName", Type = "varchar", Length = 25, Nullable = true },
                            new Column { Name = "LastName", Type = "varchar", Length = 25 },
                            new Column { Name = "Gender", Type = "varchar", Length = 1 },
                            new Column { Name = "BirthDate", Type = "datetime" }
                        },
                        Identity = new Identity("ContactID", 1, 1)
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "EmailType",
                        Columns =
                        {
                            new Column { Name = "EmailTypeID", Type = "int" },
                            new Column { Name = "Description", Type = "varchar", Length = 50 }
                        },
                        Identity = new Identity("EmailTypeID", 100, 100)
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "ContactEmail",
                        Columns =
                        {
                            new Column { Name = "ContactEmailID", Type = "int" },
                            new Column { Name = "ContactID", Type = "int" },
                            new Column { Name = "EmailTypeID", Type = "int" },
                            new Column { Name = "Email", Type = "varchar", Length = 100 }
                        },
                        Identity = new Identity("ContactEmailID", 1, 1)
                    }
                }
            }
            .AddDbObjectsFromTables()
            .SetPrimaryKeyToTables()
            .LinkTables();
    }
}
