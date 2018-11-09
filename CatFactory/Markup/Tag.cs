using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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
        public Tag()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasNamespace
            => !string.IsNullOrEmpty(Namespace);

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
        public bool HasContent
            => !string.IsNullOrEmpty(Content);

        /// <summary>
        /// 
        /// </summary>
        public bool IsSelfClosed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var output = new StringBuilder();

            var name = HasNamespace ? string.Format("{0}:{1}", Namespace, Name) : Name;

            var attributes = TagAttributes.Count == 0 ? string.Empty : string.Join(" ", TagAttributes.Select(item => string.Format("{0}=\"{1}\"", item.Name, item.Value)));

            if (IsSelfClosed)
            {
                if (TagAttributes.Count == 0)
                    output.AppendFormat("<{0} />", name);
                else
                    output.AppendFormat("<{0} {1} />", name, attributes);
            }
            else
            {
                if (TagAttributes.Count == 0)
                    output.AppendFormat("<{0}>{1}</{0}>", name, HasContent ? Content : string.Empty);
                else
                    output.AppendFormat("<{0} {1}>{2}</{0}>", name, attributes, HasContent ? Content : string.Empty);
            }

            return output.ToString();
        }
    }
}
