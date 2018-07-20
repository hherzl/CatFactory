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
        /// <returns>A <see cref="Database"/> instance that represents an existing database in DBMS</returns>
        Database Import();
    }
}
