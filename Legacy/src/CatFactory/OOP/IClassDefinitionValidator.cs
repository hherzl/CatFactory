using CatFactory.Diagnostics;

namespace CatFactory.OOP
{
    public interface IClassDefinitionValidator : IObjectDefinitionValidator
    {
        ValidationResult Validate(IClassDefinition classDefinition);
    }
}
