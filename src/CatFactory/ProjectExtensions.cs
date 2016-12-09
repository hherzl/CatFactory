using System;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class ViewExtensions
    {
        public static Boolean IsView(this ProjectFeature projectFeature, DbObject dbObject)
        {
            var view = projectFeature.Database.Views.FirstOrDefault(item => item.FullName == dbObject.FullName);

            return view == null ? false : true;
        }
    }
}
