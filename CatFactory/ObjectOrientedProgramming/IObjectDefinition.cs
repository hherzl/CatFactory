using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObjectDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        List<string> Namespaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Documentation Documentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<MetadataAttribute> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string FullName { get; }
    }
}
