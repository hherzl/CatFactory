using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory.Tests
{
    public static class ContactDatabase
    {
        public static Database Mock
        {
            get
            {
                var db = new Database()
                {
                    Name = "Store",
                    Tables = new List<Table>()
                    {
                        new Table
                        {
                            Schema = "dbo",
                            Name = "ContactType",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "ContactTypeID", Type = "int", Nullable = false },
                                new Column { Name = "Description", Type = "varchar", Length = 50, Nullable = false }
                            },
                            Identity = new Identity { Name = "ContactTypeID", Seed = 100, Increment = 100 }
                        },
                        new Table
                        {
                            Schema = "dbo",
                            Name = "Contact",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "ContactID", Type = "int", Nullable = false },
                                new Column { Name = "ContactTypeID", Type = "int", Nullable = false },
                                new Column { Name = "FirstName", Type = "varchar", Length = 25, Nullable = false },
                                new Column { Name = "MiddleName", Type = "varchar", Length = 25, Nullable = true },
                                new Column { Name = "LastName", Type = "varchar", Length = 25, Nullable = false },
                                new Column { Name = "Gender", Type = "varchar", Length = 1, Nullable = false },
                                new Column { Name = "BirthDate", Type = "datetime", Nullable = false }
                            },
                            Identity = new Identity { Name = "ContactID", Seed = 1, Increment = 1 }
                        },
                        new Table
                        {
                            Schema = "dbo",
                            Name = "EmailType",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "EmailTypeID", Type = "int", Nullable = false },
                                new Column { Name = "Description", Type = "varchar", Length = 50, Nullable = false }
                            },
                            Identity = new Identity { Name = "EmailTypeID", Seed = 100, Increment = 100 }
                        },
                        new Table
                        {
                            Schema = "dbo",
                            Name = "ContactEmail",
                            Columns = new List<Column>()
                            {
                                new Column { Name = "ContactEmailID", Type = "int", Nullable = false },
                                new Column { Name = "ContactID", Type = "int", Nullable = false },
                                new Column { Name = "EmailTypeID", Type = "int", Nullable = false },
                                new Column { Name = "Email", Type = "varchar", Length = 100, Nullable = false }
                            },
                            Identity = new Identity { Name = "ContactEmailID", Seed = 1, Increment = 1 }
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
