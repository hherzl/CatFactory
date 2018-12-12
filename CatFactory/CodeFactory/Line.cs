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
        /// <param name="value"></param>
        /// <param name="args"></param>
        public Line(int indent, string value, params string[] args)
        {
            Indent = indent;
            Content = args == null || args.Length == 0 ? value : string.Format(value, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public Line(string value, params string[] args)
        {
            Content = value;
            Content = args == null || args.Length == 0 ? value : string.Format(value, args);
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
