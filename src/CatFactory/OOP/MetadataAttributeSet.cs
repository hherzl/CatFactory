using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class MetadataAttributeSet : INameValue
    {
        public MetadataAttributeSet()
        {
        }

        public MetadataAttributeSet(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
