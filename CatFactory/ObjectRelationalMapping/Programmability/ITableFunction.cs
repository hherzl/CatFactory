using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the model for table function
    /// </summary>
    public interface ITableFunction : IReadableObject
    {
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the parameters for table function
        /// </summary>
        List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the identity for table function
        /// </summary>
        Identity Identity { get; set; }
    }
}
