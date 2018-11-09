using System.Diagnostics;

namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class TagAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public TagAttribute()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public TagAttribute(string name, string value)
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
