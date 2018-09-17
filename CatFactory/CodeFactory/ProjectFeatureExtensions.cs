using CatFactory.Mapping;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public static class ProjectFeatureExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProjectSettings"></typeparam>
        /// <param name="projectFeature"></param>
        /// <param name="dbObject"></param>
        /// <returns></returns>
        public static bool IsTable<TProjectSettings>(this ProjectFeature<TProjectSettings> projectFeature, IDbObject dbObject) where TProjectSettings : class, IProjectSettings, new()
            => projectFeature.Project.Database.FindTable(dbObject.FullName) == null ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProjectSettings"></typeparam>
        /// <param name="projectFeature"></param>
        /// <param name="dbObject"></param>
        /// <returns></returns>
        public static bool IsView<TProjectSettings>(this ProjectFeature<TProjectSettings> projectFeature, IDbObject dbObject) where TProjectSettings : class, IProjectSettings, new()
            => projectFeature.Project.Database.FindView(dbObject.FullName) == null ? false : true;
    }
}
