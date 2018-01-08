using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CatFactory.Mapping;
using Microsoft.Extensions.Logging;

namespace CatFactory
{
    [DebuggerDisplay("Name={Name}, OutputDirectory={OutputDirectory}, Features={Features.Count}, Selections={Selections.Count}")]
    public class Project<TProjectSettings> : IProject<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        public Project()
        {
        }

        public Project(ILogger<Project<TProjectSettings>> logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; }

        public string Name { get; set; }

        public Database Database { get; set; }

        public string OutputDirectory { get; set; }

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

        public virtual void AddFeature(ProjectFeature<TProjectSettings> projectFeature)
        {
            projectFeature.Project = this;

            Features.Add(projectFeature);
        }

        public virtual void BuildFeatures()
        {
            if (Database == null)
            {
                return;
            }

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
                    .ToList());
            }
        }

        public event ScaffoldingDefinition ScaffoldingDefinition;

        protected void OnScaffoldingDefinition(ScaffoldingDefinitionEventArgs args)
        {
            ScaffoldingDefinition?.Invoke(this, args);
        }

        public event ScaffoldedDefinition ScaffoldedDefinition;

        protected void OnScaffoldedDefinition(ScaffoldedDefinitionEventArgs args)
        {
            ScaffoldedDefinition?.Invoke(this, args);
        }
    }
}
