﻿namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a naming convention for database
    /// </summary>
    public class DatabaseNamingConvention : IDatabaseNamingConvention
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="DatabaseNamingConvention"/> class
        /// </summary>
        public DatabaseNamingConvention()
        {
        }

        #endregion

        #region [ Members of IDatabaseNamingConvention ]

        /// <summary>
        /// Valids a name for current naming convention
        /// </summary>
        /// <param name="name">Object name</param>
        /// <returns>A string as a valid name</returns>
        public virtual string ValidName(string name)
            => name;

        /// <summary>
        /// Gets the name for object according to current naming convention
        /// </summary>
        /// <param name="names">Names</param>
        /// <returns>A <see cref="string"/> that represents the name of object</returns>
        public virtual string GetObjectName(params string[] names)
            => string.Join(".", names);

        /// <summary>
        /// Gets the name for parameter according to current naming convention
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>A <see cref="string"/> that represents the name of parameter</returns>
        public virtual string GetParameterName(string name)
            => name;

        /// <summary>
        /// Gets the name for primary key constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        public virtual string GetPrimaryKeyConstraintName(ITable table, string[] key)
            => string.Join("_", "PK", table.Schema, table.Name);

        /// <summary>
        /// Gets the name for unique constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        public virtual string GetUniqueConstraintName(ITable table, string[] key)
            => string.Join("_", "UQ", table.Schema, table.Name, string.Join("_", key));

        /// <summary>
        /// Gets the name for foreign key constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <param name="references">References (Parent table)</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        public virtual string GetForeignKeyConstraintName(ITable table, string[] key, ITable references)
            => string.Join("_", "FK", table.Schema, table.Name, string.Join("_", key), references.Schema, references.Name);

        /// <summary>
        /// Gets the name for default constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        public virtual string GetDefaultConstraintName(ITable table, string key)
            => string.Join("_", "DF", table.Schema, table.Name, key);

        /// <summary>
        /// Gets the name for check constraint
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="key">Key for constraint</param>
        /// <returns>A <see cref="string"/> that represents the name of constraint</returns>
        public virtual string GetCheckConstraintName(ITable table, string key)
            => string.Join("_", "CK", table.Schema, table.Name, key);

        #endregion
    }
}
