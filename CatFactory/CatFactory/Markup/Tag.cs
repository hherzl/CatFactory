using System.Collections.Generic;

namespace CatFactory.Markup
{
    public class Tag
    {
        public string Namespace { get; set; }

        public string Name { get; set; }

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
