using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, Type={Type}, Nullable={Nullable ? \"Yes\": \"No\"}")]
    public class Column : IEqualityComparer<Column>
    {
        public Column()
        {
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Length { get; set; }

        public short Prec { get; set; }

        public short Scale { get; set; }

        public bool Nullable { get; set; }

        public string Collation { get; set; }

        public string Description { get; set; }

        public bool Equals(Column x, Column y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(Column obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
