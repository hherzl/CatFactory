using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class MetadataAttributeSet : INameValue
    {
        /// <summary>
        /// 
        /// </summary>
        public MetadataAttributeSet()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public MetadataAttributeSet(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }
    }
}
