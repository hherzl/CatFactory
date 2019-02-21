using System.Collections.Generic;
using CatFactory.ObjectOrientedProgramming;
using CatFactory.ObjectRelationalMapping;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProjectSettings"></typeparam>
    public interface IProject<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        /// <summary>
        /// 
        /// </summary>
        event ScaffoldingDefinition ScaffoldingDefinition;

        /// <summary>
        /// 
        /// </summary>
        event ScaffoldedDefinition ScaffoldedDefinition;

        /// <summary>
        /// 
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Database Database { get; set; }

        /// <summary>
        /// 
        /// </summary>
        ICodeNamingConvention CodeNamingConvention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        INamingService NamingService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string OutputDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<ProjectFeature<TProjectSettings>> Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<ProjectSelection<TProjectSettings>> Selections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectFeature"></param>
        void AddFeature(ProjectFeature<TProjectSettings> projectFeature);

        /// <summary>
        /// 
        /// </summary>
        void BuildFeatures();

        /// <summary>
        /// 
        /// </summary>
        List<IObjectDefinition> ObjectDefinitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        void Scaffold();
    }
}
