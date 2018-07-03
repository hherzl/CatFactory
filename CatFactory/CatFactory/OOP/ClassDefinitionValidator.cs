using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.OOP
{
    public class ClassDefinitionValidator : IClassDefinitionValidator
    {
        public virtual ValidationResult Validate(IClassDefinition classDefinition)
        {
            if (classDefinition == null)
                throw new ArgumentNullException(nameof(classDefinition));

            var result = new ValidationResult();

            if (string.IsNullOrEmpty(classDefinition.Name))
                result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, "There isn't name for class definition"));

            foreach (var field in classDefinition.Fields)
            {
                if (classDefinition.Fields.Where(p => p.Name == field.Name).Count() > 1)
                    result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("There is more than one field with name '{0}'", field.Name)));
            }

            foreach (var property in classDefinition.Properties)
            {
                if (classDefinition.Properties.Where(p => p.Name == property.Name).Count() > 1)
                    result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("There is more than one property with name '{0}'", property.Name)));
            }

            return result;
        }
    }
}
