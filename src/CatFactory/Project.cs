using System;
using System.Collections.Generic;
using System.Linq;
using CatFactory.Mapping;

namespace CatFactory
{
    public class Project
    {
        public String Name { get; set; }

        public Database Database { get; set; }

        public List<ProjectFeature> Features { get; set; }

        public String OutputDirectory { get; set; }

        public void BuildFeatures()
        {
            if (Database == null)
            {
                return;
            }

            Features = Database
                .DbObjects
                .Select(item => item.Schema)
                .Distinct()
                .Select(item => new ProjectFeature { Name = item, Database = Database, DbObjects = Database.DbObjects.Where(db => db.Schema == item).ToList() })
                .ToList();
        }
    }
}
