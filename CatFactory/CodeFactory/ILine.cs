namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILine
    {
        /// <summary>
        /// 
        /// </summary>
        int Indent { get; }

        /// <summary>
        /// 
        /// </summary>
        string Content { get; }

        /// <summary>
        /// 
        /// </summary>
        bool IsNullOrEmpty { get; }
    }
}
