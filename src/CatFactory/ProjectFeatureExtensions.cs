using CatFactory.Mapping;

namespace CatFactory
{
    public static class ProjectFeatureExtensions
    {
        public static bool IsTable<TProjectSettings>(this ProjectFeature<TProjectSettings> projectFeature, IDbObject dbObject) where TProjectSettings : class, IProjectSettings, new()
            => projectFeature.Project.Database.FindTable(dbObject.FullName) == null ? false : true;

        public static bool IsView<TProjectSettings>(this ProjectFeature<TProjectSettings> projectFeature, IDbObject dbObject) where TProjectSettings : class, IProjectSettings, new()
            => projectFeature.Project.Database.FindView(dbObject.FullName) == null ? false : true;
    }
}
