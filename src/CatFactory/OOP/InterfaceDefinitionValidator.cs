using System;
using System.Collections.Generic;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.OOP
{
    public class InterfaceDefinitionValidator : IInterfaceDefinitionValidator
    {
        public virtual IEnumerable<ValidationMessage> Validate(IInterfaceDefinition interfaceDefinition)
        {
            if (interfaceDefinition == null)
            {
                throw new ArgumentNullException(nameof(interfaceDefinition));
            }

            if (String.IsNullOrEmpty(interfaceDefinition.Name))
            {
                yield return new ValidationMessage
                {
                    LogLevel = LogLevel.Error,
                    Message = "There isn't name for interface definition"
                };
            }

            foreach (var property in interfaceDefinition.Properties)
            {
                if (interfaceDefinition.Properties.Where(p => p.Name == property.Name).Count() > 1)
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
