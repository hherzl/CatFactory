using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CatFactory.Mapping;

namespace CatFactory
{
    [DebuggerDisplay("Name={Name}, Features={Features.Count}")]
    public class Project
    {
        public Project()
        {
        }

        public String Name { get; set; }

        public Database Database { get; set; }

        public List<ProjectFeature> Features { get; set; }

        public String OutputDirectory { get; set; }

        public virtual void BuildFeatures()
        {
            if (Database == null)
            {
                return;
            }

            Features = Database
                .DbObjects
                .Select(item => item.Schema)
                .Distinct()
                .Select(item => new ProjectFeature(item, Database.DbObjects.Where(db => db.Schema == item).ToList(), Database))
                .ToList();
        }
    }
}
