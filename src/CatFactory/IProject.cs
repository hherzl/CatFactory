using System;
using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory
{
    public interface IProject
    {
        String Name { get; set; }

        Database Database { get; set; }

        List<ProjectFeature> Features { get; set; }

        String OutputDirectory { get; set; }

        List<String> AddExclusions { get; set; }

        List<String> UpdateExclusions { get; set; }

        void BuildFeatures();

        IDbObject FindObject(String fullName);
    }
}
