using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CatFactory.CodeFactory;

namespace CatFactory.Markdown
{
    /// <summary>
    /// Represents a document for markdown language
    /// </summary>
    /// <remarks>For more info: https://en.wikipedia.org/wiki/Markdown</remarks>
    public class MdDocument
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// Initializes a new instance of <see cref="MdDocument"/> class
        /// </summary>
        public MdDocument()
        {
        }

        /// <summary>
        /// Gets or sets the lines for current document
        /// </summary>
        public List<ILine> Lines
        {
            get => m_lines ?? (m_lines = new List<ILine>());
            set => m_lines = value;
        }

        /// <summary>
        /// Returns a string that represents the current document
        /// </summary>
        /// <returns>A string that represents the current document</returns>
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
