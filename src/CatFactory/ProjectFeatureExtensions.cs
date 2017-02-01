using System;
using System.Linq;
using CatFactory.Mapping;

namespace CatFactory
{
    public static class ProjectFeatureExtensions
    {
        public static Boolean IsView(this ProjectFeature projectFeature, DbObject dbObject)
            => projectFeature.Database.Views.FirstOrDefault(item => item.FullName == dbObject.FullName) == null ? false : true;
    }
}
