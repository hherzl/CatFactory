using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents the model for user table
    /// </summary>
    public interface IView : IReadableObject
    {
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets row Guid column
        /// </summary>
        RowGuidCol RowGuidCol { get; set; }

        /// <summary>
        /// Gets or sets indexes list
        /// </summary>
        List<Index> Indexes { get; set; }
    }
}
