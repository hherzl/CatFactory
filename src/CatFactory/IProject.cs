using System.Collections.Generic;
using CatFactory.Mapping;

namespace CatFactory
{
    public interface IProject
    {
        string Name { get; set; }

        Database Database { get; set; }

        string OutputDirectory { get; set; }

        List<ProjectFeature> Features { get; set; }

        void AddFeature(ProjectFeature projectFeature);

        void BuildFeatures();
    }
}
