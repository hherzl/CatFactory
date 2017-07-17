using System;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, Type={Type}, Nullable={Nullable ? \"Yes\": \"No\"}")]
    public class Column
    {
        public Column()
        {
        }

        public String Name { get; set; }

        public String Type { get; set; }

        public Int32 Length { get; set; }

        public Int16 Prec { get; set; }

        public Int16 Scale { get; set; }

        public Boolean Nullable { get; set; }

        public String Collation { get; set; }

        public String Description { get; set; }

        public override Boolean Equals(Object obj)
        {
            var cast = obj as Column;

            if (cast != null)
            {
                return String.Compare(Name, cast.Name) == 0 ? true : false;
            }

            return false;
        }

        public override Int32 GetHashCode()
            => Name == null ? 0 : Name.GetHashCode();
    }
}
