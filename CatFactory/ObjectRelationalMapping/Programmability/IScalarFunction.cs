using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the model for scalar function
    /// </summary>
    public interface IScalarFunction
    {
        /// <summary>
        /// Gets or sets the parameters for scalar function
        /// </summary>
        List<Parameter> Parameters { get; set; }
    }
}
