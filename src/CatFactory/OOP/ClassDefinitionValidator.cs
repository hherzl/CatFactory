using System;
using System.Collections.Generic;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.OOP
{
    public class ClassDefinitionValidator : IClassDefinitionValidator
    {
        public virtual IEnumerable<ValidationMessage> Validate(IClassDefinition classDefinition)
        {
            if (classDefinition == null)
            {
                throw new ArgumentNullException(nameof(classDefinition));
            }

            if (String.IsNullOrEmpty(classDefinition.Name))
            {
                yield return new ValidationMessage
                {
                    LogLevel = LogLevel.Error,
                    Message = "There isn't name for class definition"
                };
            }

            foreach (var field in classDefinition.Fields)
            {
                if (classDefinition.Fields.Where(p => p.Name == field.Name).Count() > 1)
                {
                    yield return new ValidationMessage
                    {
                        LogLevel = LogLevel.Error,
                        Message = String.Format("There is more than one field with name '{0}'", field.Name)
                    };
                }
            }

            foreach (var property in classDefinition.Properties)
            {
                if (classDefinition.Properties.Where(p => p.Name == property.Name).Count() > 1)
                {
                    yield return new ValidationMessage
                    {
                        LogLevel = LogLevel.Error,
                        Message = String.Format("There is more than one property with name '{0}'", property.Name)
                    };
                }
            }
        }
    }
}
