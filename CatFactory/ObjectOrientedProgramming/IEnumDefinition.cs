using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
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
        List<NameValue> Sets { get; set; }
    }
}
