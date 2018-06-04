namespace CatFactory.Mapping
{
    /// <summary>
    /// Contains all operations related to import database feature
    /// </summary>
    public interface IDatabaseFactory
    {
        /// <summary>
        /// Import an existing database
        /// </summary>
        /// <returns>A <see cref="CatFactory.Mapping.Database"/> instance that represents an existing database in database server</returns>
        Database Import();
    }
}
