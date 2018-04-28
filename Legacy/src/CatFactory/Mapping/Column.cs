using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, Type={Type}, Nullable={Nullable ? \"Yes\": \"No\"}")]
    public class Column
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

        public override bool Equals(object obj)
        {
            var cast = obj as Column;

            return cast == null ? false : string.Compare(Name, cast.Name) == 0 ? true : false;
        }

        public override int GetHashCode()
            => Name == null ? 0 : Name.GetHashCode();
    }
}
