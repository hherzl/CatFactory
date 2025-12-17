using CatFactory.ObjectRelationalMapping;

namespace CatFactory.Tests.Models
{
    public static partial class Databases
    {
        public static Database Contact
            => new Database
            {
                Name = "Contact",
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
                            new Column("ContactTypeId", "int"),
                            new Column("Description", "varchar", 50)
                        },
                        Identity = new("ContactTypeId", 100, 100)
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "Contact",
                        Columns =
                        {
                            new Column("ContactId", "int"),
                            new Column("ContactTypeId", "int"),
                            new Column("FirstName", "varchar", 10),
                            new Column("MiddleName", "varchar", 10, true),
                            new Column("LastName", "varchar", 10),
                            new Column("Gender", "varchar", 1),
                            new Column("BirthDate", "datetime")
                        },
                        Identity = new("ContactId")
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "EmailType",
                        Columns =
                        {
                            new Column("EmailTypeId", "int"),
                            new Column("Description", "varchar", 50)
                        },
                        Identity = new("EmailTypeID", 100, 100)
                    },
                    new Table
                    {
                        Schema = "dbo",
                        Name = "ContactEmail",
                        Columns =
                        {
                            new Column("ContactEmailId", "int"),
                            new Column("ContactId", "int"),
                            new Column("EmailTypeId", "int"),
                            new Column("Email", "varchar", 100)
                        },
                        Identity = new("ContactEmailId")
                    }
                }
            }
            .AddDbObjectsFromTables()
            .SetPrimaryKeyForTables()
            .LinkTables();
    }
}
