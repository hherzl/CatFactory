using System.Diagnostics;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Content={Content}")]
    public class Line : ILine
    {
        /// <summary>
        /// 
        /// </summary>
        public Line()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indent"></param>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public Line(int indent, string content, params string[] values)
        {
            Indent = indent;
            Content = values == null || values.Length == 0 ? content : string.Format(content, values);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public Line(string content, params string[] values)
        {
            Content = content;
            Content = values == null || values.Length == 0 ? content : string.Format(content, values);
        }

        /// <summary>
        /// 
        /// </summary>
        public int Indent { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        public string Content { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsNullOrEmpty
            => string.IsNullOrEmpty(Content);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => Content;
    }
}
