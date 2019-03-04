using CatFactory.ObjectRelationalMapping;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Provides extension methods for <see cref="ProjectFeature{TProjectSettings}"/> class
    /// </summary>
    public static class ProjectFeatureExtensions
    {
        /// <summary>
        /// Indicates if database object is a table
        /// </summary>
        /// <typeparam name="TProjectSettings">Project settings</typeparam>
        /// <param name="projectFeature">Project feature</param>
        /// <param name="dbObject">Database object</param>
        /// <returns>True if database object is a table, otherwise false</returns>
        public static bool IsTable<TProjectSettings>(this ProjectFeature<TProjectSettings> projectFeature, IDbObject dbObject) where TProjectSettings : class, IProjectSettings, new()
            => projectFeature.Project.Database.FindTable(dbObject.FullName) == null ? false : true;

        /// <summary>
        /// Indicates if database object is a view
        /// </summary>
        /// <typeparam name="TProjectSettings">Project settings</typeparam>
        /// <param name="projectFeature">Project feature</param>
        /// <param name="dbObject">Database object</param>
        /// <returns>True if database object is a view, otherwise false</returns>
        public static bool IsView<TProjectSettings>(this ProjectFeature<TProjectSettings> projectFeature, IDbObject dbObject) where TProjectSettings : class, IProjectSettings, new()
            => projectFeature.Project.Database.FindView(dbObject.FullName) == null ? false : true;
    }
}
