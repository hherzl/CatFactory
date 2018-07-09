using System;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a factory to import an existing database
    /// </summary>
    public class DatabaseFactory : IDatabaseFactory
    {
        /// <summary>
        /// Import an existing database
        /// </summary>
        /// <returns>A <see cref="Database"/> instance that represents an existing database in database server</returns>
        public virtual Database Import()
        {
            throw new NotImplementedException();
        }
    }
}
