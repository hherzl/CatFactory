using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.OOP
{
    public class InterfaceDefinitionValidator : IInterfaceDefinitionValidator
    {
        public virtual ValidationResult Validate(IInterfaceDefinition interfaceDefinition)
        {
            if (interfaceDefinition == null)
                throw new ArgumentNullException(nameof(interfaceDefinition));

            var result = new ValidationResult
            {
                IsValid = true
            };

            if (string.IsNullOrEmpty(interfaceDefinition.Name))
            {
                result.IsValid = false;

                result.ValidationMessages.Add(new ValidationMessage
                {
                    LogLevel = LogLevel.Error,
                    Message = "There isn't name for interface definition"
                });
            }

            foreach (var property in interfaceDefinition.Properties)
            {
                result.IsValid = false;

                if (interfaceDefinition.Properties.Where(p => p.Name == property.Name).Count() > 1)
                {
                    result.ValidationMessages.Add(new ValidationMessage
                    {
                        LogLevel = LogLevel.Error,
                        Message = string.Format("There is more than one property with name '{0}'", property.Name)
                    });
                }
            }

            return result;
        }
    }
}
