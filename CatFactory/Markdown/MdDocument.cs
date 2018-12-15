using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CatFactory.CodeFactory;

namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MdDocument
    {
        /// <summary>
        /// 
        /// </summary>
        public MdDocument()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// 
        /// </summary>
        public List<ILine> Lines
        {
            get
            {
                return m_lines ?? (m_lines = new List<ILine>());
            }
            set
            {
                m_lines = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var output = new StringBuilder();

            for (var i = 0; i < Lines.Count; i++)
            {
                var line = Lines[i];

                if (i == Lines.Count - 1)
                    output.Append(line.ToString());
                else
                    output.AppendLine(line.ToString());
            }

            return output.ToString();
        }
    }
}
