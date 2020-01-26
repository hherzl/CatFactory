namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a naming convention for database
    /// </summary>
    public interface IDatabaseNamingConvention : INamingConvention
    {
        /// <summary>
        /// Gets the name for object according to current naming convention
        /// </summary>
        /// <param name="names">Names</param>
        /// <returns>A <see cref="string"/> that represents the name of the object</returns>
        string GetObjectName(params string[] names);

        /// <summary>
        /// Gets the name for parameter according to current naming convention
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>A <see cref="string"/> that represents the name of parameter</returns>
        string GetParameterName(string name);

        /// <summary>
        /// Gets the name for primary key constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> as constraint's name</returns>
        string GetPrimaryKeyConstraintName(ITable table, string[] key);

        /// <summary>
        /// Gets the name for unique constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        string GetUniqueConstraintName(ITable table, string[] key);

        /// <summary>
        /// Gets the name for foreign key constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <param name="references">References (Parent table)</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        string GetForeignKeyConstraintName(ITable table, string[] key, ITable references);

        /// <summary>
        /// Gets the name for default constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        string GetDefaultConstraintName(ITable table, string key);

        /// <summary>
        /// Gets the name for check constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        string GetCheckConstraintName(ITable table, string key);
    }
}
