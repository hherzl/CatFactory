using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CatFactory.ObjectOrientedProgramming;
using CatFactory.ObjectRelationalMapping;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Represents a scaffolding project
    /// </summary>
    /// <typeparam name="TProjectSettings">Settings for project</typeparam>
    [DebuggerDisplay("Name={Name}, OutputDirectory={OutputDirectory}, Features={Features.Count}, Selections={Selections.Count}")]
    public class Project<TProjectSettings> : IProject<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        /// <summary>
        /// Occurs before of create the output file
        /// </summary>
        public event ScaffoldingDefinition ScaffoldingDefinition;

        /// <summary>
        /// Occurs after of create the output file
        /// </summary>
        public event ScaffoldedDefinition ScaffoldedDefinition;

        /// <summary>
        /// Initializes a new instance of <see cref="Project{TProjectSettings}"/> class
        /// </summary>
        public Project()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Project{TProjectSettings}"/> class
        /// </summary>
        /// <param name="logger">Instance of <see cref="Logger{T}"/> class</param>
        public Project(ILogger<Project<TProjectSettings>> logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Gets the instance of <see cref="Logger"/>
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Database"/> instance
        /// </summary>
        public Database Database { get; set; }

        /// <summary>
        /// Gets or sets the implementation for <see cref="ICodeNamingConvention"/> interface
        /// </summary>
        public ICodeNamingConvention CodeNamingConvention { get; set; }

        /// <summary>
        /// Gets or sets the implementation for <see cref="INamingConvention"/> interface
        /// </summary>
        public INamingService NamingService { get; set; }

        /// <summary>
        /// Gets or sets the output directory
        /// </summary>
        public string OutputDirectory { get; set; }

        /// <summary>
        /// Gets a project feature by index
        /// </summary>
        /// <param name="index">Project feature index</param>
        /// <returns>A <see cref="Project{TProjectSettings}"/> from features list</returns>
        public ProjectFeature<TProjectSettings> this[int index]
        {
            get
            {
                return Features[index];
            }
            set
            {
                Features[index] = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ProjectFeature<TProjectSettings>> m_features;

        /// <summary>
        /// Gets or sets the features
        /// </summary>
        public List<ProjectFeature<TProjectSettings>> Features
        {
            get
            {
                return m_features ?? (m_features = new List<ProjectFeature<TProjectSettings>>());
            }
            set
            {
                m_features = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ProjectSelection<TProjectSettings>> m_selections;

        /// <summary>
        /// Gets or sets the selections
        /// </summary>
        public List<ProjectSelection<TProjectSettings>> Selections
        {
            get
            {
                return m_selections ?? (m_selections = new List<ProjectSelection<TProjectSettings>>());
            }
            set
            {
                m_selections = value;
            }
        }

        /// <summary>
        /// Adds an instance of <see cref="Project{TProjectSettings}"/> in features list
        /// </summary>
        /// <param name="projectFeature">Instance of <see cref="Project{TProjectSettings}"/> class</param>
        public virtual void AddFeature(ProjectFeature<TProjectSettings> projectFeature)
        {
            projectFeature.Project = this;

            Features.Add(projectFeature);
        }

        /// <summary>
        /// Builds the features for project using <see cref="Database"/> representation
        /// </summary>
        public virtual void BuildFeatures()
        {
            if (Database == null)
                return;

            if (Database.DbObjects.Count > 0)
            {
                Features.AddRange(Database
                    .DbObjects
                    .Select(item => item.Schema)
                    .Distinct()
                    .Select(schema => new ProjectFeature<TProjectSettings>(schema, Database.GetDbObjectsBySchema(schema), this))
                    .ToList()
                    );
            }
        }

        /// <summary>
        /// Scaffolds output files
        /// </summary>
        /// <param name="objectDefinition">Implementation of <see cref="IObjectDefinition"/> interface</param>
        /// <param name="outputDirectory">Output directory path</param>
        /// <param name="subdirectory">Subdirectory name</param>
        public virtual void Scaffold(IObjectDefinition objectDefinition, string outputDirectory, string subdirectory = "")
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        protected void OnScaffoldingDefinition(ScaffoldingDefinitionEventArgs args)
        {
            ScaffoldingDefinition?.Invoke(this, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        protected void OnScaffoldedDefinition(ScaffoldedDefinitionEventArgs args)
        {
            ScaffoldedDefinition?.Invoke(this, args);
        }
    }
}
