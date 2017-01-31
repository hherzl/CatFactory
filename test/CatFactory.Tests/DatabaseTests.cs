using System.Linq;
using Xunit;

namespace CatFactory.Tests
{
    public class DatabaseTests
    {
        [Fact]
        public void ValidateContactDatabase()
        {
            var db = ContactDatabase.Mock;

            var contactTypeTable = db.Tables.First(item => item.FullName == "dbo.ContactType");
            var contactTable = db.Tables.First(item => item.FullName == "dbo.Contact");
            var contactEmailTable = db.Tables.First(item => item.FullName == "dbo.ContactEmail");

            Assert.True(contactTypeTable.ForeignKeys.Count == 0);
            Assert.True(contactTable.ForeignKeys.Count == 1);
            Assert.True(contactEmailTable.ForeignKeys.Count == 2);
        }
    }
}
