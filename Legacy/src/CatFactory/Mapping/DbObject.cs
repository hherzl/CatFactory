using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Type={Type}, FullName={FullName}")]
    public class DbObject : IDbObject
    {
        public DbObject()
        {
        }

        public string Schema { get; set; }

        public string Name { get; set; }

        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        public string Type { get; set; }
    }
}
