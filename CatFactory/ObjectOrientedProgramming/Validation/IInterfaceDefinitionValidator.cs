using CatFactory.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInterfaceDefinitionValidator : IObjectDefinitionValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectDefinition"></param>
        /// <returns></returns>
        ValidationResult Validate(IInterfaceDefinition objectDefinition);
    }
}
