using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents the model for view
    /// </summary>
    public interface IView : IReadableObject
    {
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets indexes list
        /// </summary>
        List<Index> Indexes { get; set; }
    }
}
