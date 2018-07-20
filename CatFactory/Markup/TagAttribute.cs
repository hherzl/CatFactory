using System.Diagnostics;

namespace CatFactory.Markup
{
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class TagAttribute
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
