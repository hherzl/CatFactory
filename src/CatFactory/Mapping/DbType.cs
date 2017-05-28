using System;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, IsUserDefined={IsUserDefined}")]
    public class DbType
    {
        public DbType()
        {
        }

        public String Name { get; set; }

        public Boolean IsUserDefined { get; set; }
    }
}
