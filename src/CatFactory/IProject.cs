using System;
using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory
{
    public interface IProject
    {
        String Name { get; set; }

        Database Database { get; set; }

        List<String> AddExclusions { get; set; }

        List<String> UpdateExclusions { get; set; }

        List<ProjectFeature> Features { get; set; }

        void AddFeature(ProjectFeature projectFeature);

        void BuildFeatures();

        String OutputDirectory { get; set; }
    }
}
