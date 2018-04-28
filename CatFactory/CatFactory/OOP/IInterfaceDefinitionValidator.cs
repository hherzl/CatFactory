using CatFactory.Diagnostics;

namespace CatFactory.OOP
{
    public interface IInterfaceDefinitionValidator : IObjectDefinitionValidator
    {
        ValidationResult Validate(IInterfaceDefinition objectDefinition);
    }
}
