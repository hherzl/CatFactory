using System;
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

        public MetadataAttribute(String name, params String[] arguments)
        {
            Name = name;
            Arguments.AddRange(arguments);
        }

        public String Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<String> m_arguments;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttributeSet> m_sets;

        public List<String> Arguments
        {
            get
            {
                return m_arguments ?? (m_arguments = new List<String>());
            }
            set
            {
                m_arguments = value;
            }
        }

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

        public Boolean HasArguments
            => Arguments.Count > 0;

        public Boolean HasSets
            => Sets.Count > 0;

        public Boolean HasMembers
            => HasArguments || HasSets;
    }
}
