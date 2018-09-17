using CatFactory.Diagnostics;

namespace CatFactory.OOP
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
