using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory.Tests.Models
{
    public static class ContactDatabase
    {
        public static Database Mock
            => new Database
            {
                Name = "Store",
                Tables = new List<Table>
                {
                    new Table
                    {
                        Schema = "dbo",
                        Name = "ContactType",
                        Columns = new List<Column>
                        {
                            new Column { Name = "ContactTypeID", Type = "int" },
                            new Column { Name = "Description", Type = "varchar", Length = 50 }
                        },
                        Identity = new Identity { Name = "ContactTypeID", Seed = 100, Increment = 100 }
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "Contact",
                        Columns = new List<Column>
                        {
                            new Column { Name = "ContactID", Type = "int" },
                            new Column { Name = "ContactTypeID", Type = "int" },
                            new Column { Name = "FirstName", Type = "varchar", Length = 25 },
                            new Column { Name = "MiddleName", Type = "varchar", Length = 25, Nullable = true },
                            new Column { Name = "LastName", Type = "varchar", Length = 25 },
                            new Column { Name = "Gender", Type = "varchar", Length = 1 },
                            new Column { Name = "BirthDate", Type = "datetime" }
                        },
                        Identity = new Identity { Name = "ContactID", Seed = 1, Increment = 1 }
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "EmailType",
                        Columns = new List<Column>
                        {
                            new Column { Name = "EmailTypeID", Type = "int" },
                            new Column { Name = "Description", Type = "varchar", Length = 50 }
                        },
                        Identity = new Identity { Name = "EmailTypeID", Seed = 100, Increment = 100 }
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "ContactEmail",
                        Columns = new List<Column>
                        {
                            new Column { Name = "ContactEmailID", Type = "int" },
                            new Column { Name = "ContactID", Type = "int" },
                            new Column { Name = "EmailTypeID", Type = "int" },
                            new Column { Name = "Email", Type = "varchar", Length = 100 }
                        },
                        Identity = new Identity { Name = "ContactEmailID", Seed = 1, Increment = 1 }
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
