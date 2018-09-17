using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}, TagAttributes={TagAttributes.Count}, IsSelfClosed={IsSelfClosed}")]
    public class Tag
    {
        /// <summary>
        /// 
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TagAttribute> m_tagAttributes;

        /// <summary>
        /// 
        /// </summary>
        public List<TagAttribute> TagAttributes
        {
            get
            {
                return m_tagAttributes ?? (m_tagAttributes = new List<TagAttribute>());
            }
            set
            {
                m_tagAttributes = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSelfClosed { get; set; }
    }
}
