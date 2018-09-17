using CatFactory.Diagnostics;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProjectSettings
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ValidationResult Validate();
    }
}
