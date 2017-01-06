using System;
using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.Mapping;

namespace CatFactory
{
    [DebuggerDisplay("Name={Name}, DbObjects={DbObjects.Count}")]
    public class ProjectFeature
    {
        public ProjectFeature()
        {
        }

        public ProjectFeature(String name, List<DbObject> dbObjects, Database database)
        {
            Name = name;
            DbObjects = dbObjects;
            Database = database;
        }

        public String Name { get; set; }

        public List<DbObject> DbObjects { get; set; }

        public Database Database { get; set; }

        public String Description { get; set; }
    }
}
