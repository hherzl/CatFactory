using System.Collections.Generic;

namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEnumDefinition : IObjectDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        string BaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<INameValue> Sets { get; set; }
    }
}
