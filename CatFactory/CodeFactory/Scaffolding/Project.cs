using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CatFactory.ObjectRelationalMapping;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProjectSettings"></typeparam>
    [DebuggerDisplay("Name={Name}, OutputDirectory={OutputDirectory}, Features={Features.Count}, Selections={Selections.Count}")]
    public class Project<TProjectSettings> : IProject<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        /// <summary>
        /// 
        /// </summary>
        public Project()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public Project(ILogger<Project<TProjectSettings>> logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Database Database { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICodeNamingConvention CodeNamingConvention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public INamingService NamingService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OutputDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="projectFeature"></param>
        public virtual void AddFeature(ProjectFeature<TProjectSettings> projectFeature)
        {
            projectFeature.Project = this;

            Features.Add(projectFeature);
        }

        /// <summary>
        /// 
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
                    .Select(schema => new ProjectFeature<TProjectSettings>(schema, Database.GetDbObjectsBySchema(schema))
                    {
                        Project = this
                    })
                    .ToList()
                    );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public event ScaffoldingDefinition ScaffoldingDefinition;

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
        public event ScaffoldedDefinition ScaffoldedDefinition;

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
