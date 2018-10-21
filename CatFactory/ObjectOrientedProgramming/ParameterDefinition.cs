using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Type={Type}, Name={Name}, DefaultValue={DefaultValue}")]
    public class ParameterDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public ParameterDefinition()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="attributes"></param>
        public ParameterDefinition(string type, string name, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attributes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="defaultValue"></param>
        /// <param name="attributes"></param>
        public ParameterDefinition(string type, string name, string defaultValue, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
            Attributes.AddRange(attributes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        /// <summary>
        /// 
        /// </summary>
        public Documentation Documentation
        {
            get
            {
                return m_documentation ?? (m_documentation = new Documentation());
            }
            set
            {
                m_documentation = value;
            }
        }

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

        /// <summary>
        /// 
        /// </summary>
        public bool IsParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DefaultValue { get; set; }
    }
}
