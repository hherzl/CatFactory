using System.Collections.Generic;
using CatFactory.ObjectOrientedProgramming;
using CatFactory.ObjectRelationalMapping;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Represents the abstract model for Project in CatFactory
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
        /// Gets the instance of <see cref="Logger"/>
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Database"/> instance
        /// </summary>
        Database Database { get; set; }

        /// <summary>
        /// Gets or sets the implementation for <see cref="ICodeNamingConvention"/> interface
        /// </summary>
        ICodeNamingConvention CodeNamingConvention { get; set; }

        /// <summary>
        /// Gets or sets the implementation for <see cref="INamingConvention"/> interface
        /// </summary>
        INamingService NamingService { get; set; }

        /// <summary>
        /// Gets or sets the output directory
        /// </summary>
        string OutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets the features
        /// </summary>
        List<ProjectFeature<TProjectSettings>> Features { get; set; }

        /// <summary>
        /// Gets or sets the selections
        /// </summary>
        List<ProjectSelection<TProjectSettings>> Selections { get; set; }

        /// <summary>
        /// Adds an instance of <see cref="Project{TProjectSettings}"/> in features list
        /// </summary>
        /// <param name="projectFeature">Instance of <see cref="Project{TProjectSettings}"/> class</param>
        void AddFeature(ProjectFeature<TProjectSettings> projectFeature);

        /// <summary>
        /// Builds the features for project using <see cref="Database"/> representation
        /// </summary>
        void BuildFeatures();

        /// <summary>
        /// Scaffolds output files
        /// </summary>
        /// <param name="objectDefinition">Implementation of <see cref="IObjectDefinition"/> interface</param>
        /// <param name="outputDirectory">Output directory path</param>
        /// <param name="subdirectory">Subdirectory name</param>
        void Scaffold(IObjectDefinition objectDefinition, string outputDirectory, string subdirectory = "");
    }
}
