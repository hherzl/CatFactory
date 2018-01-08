using System.Collections.Generic;
using CatFactory.Mapping;
using Microsoft.Extensions.Logging;

namespace CatFactory
{
    public interface IProject<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        ILogger Logger { get; }

        string Name { get; set; }

        Database Database { get; set; }

        string OutputDirectory { get; set; }

        List<ProjectFeature<TProjectSettings>> Features { get; set; }

        List<ProjectSelection<TProjectSettings>> Selections { get; set; }

        void AddFeature(ProjectFeature<TProjectSettings> projectFeature);

        void BuildFeatures();

        event ScaffoldingDefinition ScaffoldingDefinition;

        event ScaffoldedDefinition ScaffoldedDefinition;
    }
}
