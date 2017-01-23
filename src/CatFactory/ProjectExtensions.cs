using System;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class ViewExtensions
    {
        public static Boolean IsView(this ProjectFeature projectFeature, DbObject dbObject)
            => projectFeature.Database.Views.FirstOrDefault(item => item.FullName == dbObject.FullName) == null ? false : true;
    }
}
