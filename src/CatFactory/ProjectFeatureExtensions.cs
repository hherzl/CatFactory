using CatFactory.Mapping;

namespace CatFactory
{
    public static class ProjectFeatureExtensions
    {
        public static bool IsTable(this ProjectFeature projectFeature, IDbObject dbObject)
            => projectFeature.Project.Database.FindTableByFullName(dbObject.FullName) == null ? false : true;

        public static bool IsView(this ProjectFeature projectFeature, IDbObject dbObject)
            => projectFeature.Project.Database.FindViewByFullName(dbObject.FullName) == null ? false : true;
    }
}
