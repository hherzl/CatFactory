using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
    public class InterfaceDefinitionValidator : IInterfaceDefinitionValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="interfaceDefinition"></param>
        /// <returns></returns>
        public virtual ValidationResult Validate(IInterfaceDefinition interfaceDefinition)
        {
            if (interfaceDefinition == null)
                throw new ArgumentNullException(nameof(interfaceDefinition));

            var result = new ValidationResult();

            if (string.IsNullOrEmpty(interfaceDefinition.Name))
                result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, "There isn't name for interface definition"));

            foreach (var property in interfaceDefinition.Properties)
            {
                if (interfaceDefinition.Properties.Where(p => p.Name == property.Name).Count() > 1)
                    result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("There is more than one property with name '{0}'", property.Name)));
            }

            return result;
        }
    }
}
