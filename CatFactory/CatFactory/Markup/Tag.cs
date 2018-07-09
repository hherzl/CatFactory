using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}, TagAttributes={TagAttributes.Count}, IsSelfClosed={IsSelfClosed}")]
    public class Tag
    {
        public string Namespace { get; set; }

        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TagAttribute> m_tagAttributes;

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

        public string Content { get; set; }

        public bool IsSelfClosed { get; set; }
    }
}
