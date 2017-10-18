using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, IsUserDefined={IsUserDefined}")]
    public class DbType
    {
        public DbType()
        {
        }

        public string Name { get; set; }

        public bool IsUserDefined { get; set; }
    }
}
