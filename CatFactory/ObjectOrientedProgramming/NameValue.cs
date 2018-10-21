using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class NameValue : INameValue
    {
        /// <summary>
        /// 
        /// </summary>
        public NameValue()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public NameValue(string name, string value)
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        /// <summary>
        /// 
        /// </summary>
        public List<MetadataAttribute> Attributes
        {
            get
            {
                return m_attributes ?? (m_attributes = new List<MetadataAttribute>());
            }
            set
            {
                m_attributes = value;
            }
        }
    }
}
