using System.Diagnostics;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class TagAttribute
    {
        public TagAttribute()
        {
        }

        public TagAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }

        public string Value { get; set; }
    }
#pragma warning restore CS1591
}
