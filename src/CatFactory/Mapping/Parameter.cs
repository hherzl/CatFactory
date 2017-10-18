using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, Type={Type}, Length={Length}")]
    public class Parameter
    {
        public Parameter()
        {
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Length { get; set; }

        public short Prec { get; set; }

        public short Scale { get; set; }

        public short ParamOrder { get; set; }

        public string Collation { get; set; }
    }
}
