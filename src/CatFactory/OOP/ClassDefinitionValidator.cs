using System;

namespace CatFactory.OOP
{
    public class ClassDefinitionValidator : IClassDefinitionValidator
    {
        public ClassDefinitionValidator()
        {
        }

        public virtual Boolean Validate(ClassDefinition classDefinition)
        {
            return true;
        }
    }
}
