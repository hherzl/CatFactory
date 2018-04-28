using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}")]
    public class RowGuidCol
    {
        public RowGuidCol()
        {
        }

        public string Name { get; set; }
    }
}
