using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Name={Name}, Arguments={Arguments.Count}, Sets={Sets.Count}")]
    public class MetadataAttribute
    {
        public MetadataAttribute()
        {
        }

        public MetadataAttribute(string name, params string[] arguments)
        {
            Name = name;
            Arguments.AddRange(arguments);
        }

        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_arguments;

        public List<string> Arguments
        {
            get
            {
                return m_arguments ?? (m_arguments = new List<string>());
            }
            set
            {
                m_arguments = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttributeSet> m_sets;

        public List<MetadataAttributeSet> Sets
        {
            get
            {
                return m_sets ?? (m_sets = new List<MetadataAttributeSet>());
            }
            set
            {
                m_sets = value;
            }
        }

        public bool HasArguments
            => Arguments.Count > 0;

        public bool HasSets
            => Sets.Count > 0;

        public bool HasMembers
            => HasArguments || HasSets;
    }
}
