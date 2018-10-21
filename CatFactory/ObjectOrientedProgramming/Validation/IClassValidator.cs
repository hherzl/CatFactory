using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClassValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="classDefinition"></param>
        /// <returns></returns>
        IEnumerable<ValidationMessage> Validate(ClassDefinition classDefinition);
    }
}
