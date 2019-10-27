using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the model for stored procedure
    /// </summary>
    public interface IStoredProcedure
    {
        /// <summary>
        /// Gets or sets the parameters for stored procedure
        /// </summary>
        List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the result sets for stored procedure
        /// </summary>
        List<ResultSet> ResultSets { get; set; }
    }
}
