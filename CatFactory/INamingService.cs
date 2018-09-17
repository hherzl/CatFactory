namespace CatFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface INamingService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Singularize(string value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Pluralize(string value);
    }
}
