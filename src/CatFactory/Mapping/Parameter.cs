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

        public short Length { get; set; }

        public int Prec { get; set; }

        public int Scale { get; set; }

        public int ParamOrder { get; set; }

        public string Collation { get; set; }
    }
}
