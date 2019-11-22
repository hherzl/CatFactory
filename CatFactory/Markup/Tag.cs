using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}, TagAttributes={TagAttributes.Count}, IsSelfClosed={IsSelfClosed}")]
    public class Tag
    {
        public static Tag Create(string name, object attribs = null, string ns = "", bool isSelfClosed = false, string content = "")
            => new Tag
            {
                Name = name,
                Namespace = ns,
                Attributes = attribs?.GetTagAttribs(),
                Content = content,
                IsSelfClosed = isSelfClosed
            };

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TagAttribute> m_attributes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Tag> m_children;

        public Tag()
        {
        }

        public string Namespace { get; set; }

        public bool HasNamespace
            => !string.IsNullOrEmpty(Namespace);

        public string Name { get; set; }

        public List<TagAttribute> Attributes
        {
            get => m_attributes ?? (m_attributes = new List<TagAttribute>());
            set => m_attributes = value;
        }

        public List<Tag> Children
        {
            get => m_children ?? (m_children = new List<Tag>());
            set => m_children = value;
        }

        public string Content { get; set; }

        public bool HasContent
            => !string.IsNullOrEmpty(Content);

        public bool IsSelfClosed { get; set; }

        public override string ToString()
        {
            var output = new StringBuilder();

            var name = HasNamespace ? string.Format("{0}:{1}", Namespace, Name) : Name;

            var attributes = Attributes.Count == 0 ? string.Empty : string.Join(" ", Attributes.Select(item => string.Format("{0}=\"{1}\"", item.Name, item.Value)));

            if (IsSelfClosed)
            {
                if (Attributes.Count == 0)
                    output.AppendFormat("<{0} />", name);
                else
                    output.AppendFormat("<{0} {1} />", name, attributes);
            }
            else
            {
                if (Children.Count == 0)
                {
                    if (Attributes.Count == 0)
                        output.AppendFormat("<{0}>{1}</{0}>", name, HasContent ? Content : string.Empty);
                    else
                        output.AppendFormat("<{0} {1}>{2}</{0}>", name, attributes, HasContent ? Content : string.Empty);
                }
                else
                {
                    if (Attributes.Count == 0)
                        output.AppendFormat("<{0}>", name);
                    else
                        output.AppendFormat("<{0} {1}>", name, attributes);

                    foreach (var child in Children)
                    {
                        output.Append(child.ToString());
                    }

                    output.AppendFormat("</{0}>", name);
                }
            }

            return output.ToString();
        }
    }
#pragma warning restore CS1591
}
