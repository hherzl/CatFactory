using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Name={Name}, Arguments={Arguments.Count}, Sets={Sets.Count}")]
    public class MetadataAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public MetadataAttribute()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        public MetadataAttribute(string name, params string[] arguments)
        {
            Name = name;
            Arguments.AddRange(arguments);
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_arguments;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public bool HasArguments
            => Arguments.Count > 0;

        /// <summary>
        /// 
        /// </summary>
        public bool HasSets
            => Sets.Count > 0;

        /// <summary>
        /// 
        /// </summary>
        public bool HasMembers
            => HasArguments || HasSets;
    }
}
