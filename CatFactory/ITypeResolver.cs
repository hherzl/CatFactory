using System;

namespace CatFactory
{
    /// <summary>
    /// 
    /// </summary>
    [Obsolete("Replace this object with DatabaseTypeMap list to resolve types between CLR and database")]
    public interface ITypeResolver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        string Resolve(string type);
    }
}
