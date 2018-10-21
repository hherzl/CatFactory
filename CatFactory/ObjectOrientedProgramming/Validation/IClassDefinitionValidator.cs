using CatFactory.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClassDefinitionValidator : IObjectDefinitionValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="classDefinition"></param>
        /// <returns></returns>
        ValidationResult Validate(IClassDefinition classDefinition);
    }
}
