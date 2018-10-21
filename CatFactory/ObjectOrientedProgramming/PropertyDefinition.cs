using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class PropertyDefinition : IMemberDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public PropertyDefinition()
        {
            IsAutomatic = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="attribs"></param>
        public PropertyDefinition(string type, string name, params MetadataAttribute[] attribs)
        {
            IsAutomatic = true;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessModifier"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="attribs"></param>
        public PropertyDefinition(AccessModifier accessModifier, string type, string name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
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

        /// <summary>
        /// 
        /// </summary>
        public bool IsVirtual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAutomatic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsReadOnly { get; set; }

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
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_getBody;

        /// <summary>
        /// 
        /// </summary>
        public List<ILine> GetBody
        {
            get
            {
                return m_getBody ?? (m_getBody = new List<ILine>());
            }
            set
            {
                m_getBody = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_setBody;

        /// <summary>
        /// 
        /// </summary>
        public List<ILine> SetBody
        {
            get
            {
                return m_setBody ?? (m_setBody = new List<ILine>());
            }
            set
            {
                m_setBody = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InitializationValue { get; set; }
    }
}
