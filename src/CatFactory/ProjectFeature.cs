using System;
using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory
{
    public class ProjectFeature
    {
        public ProjectFeature()
        {
        }

        public String Name { get; set; }

        public List<DbObject> DbObjects { get; set; }

        public Database Database { get; set; }
    }
}
