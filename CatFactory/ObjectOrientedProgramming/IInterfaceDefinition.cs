using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInterfaceDefinition : IObjectDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        bool IsPartial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<GenericTypeDefinition> GenericTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<string> Implements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool HasInheritance { get; }

        /// <summary>
        /// 
        /// </summary>
        List<EventDefinition> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<PropertyDefinition> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<MethodDefinition> Methods { get; set; }
    }
}
