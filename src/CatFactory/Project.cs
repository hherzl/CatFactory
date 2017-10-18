using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CatFactory.Mapping;

namespace CatFactory
{
    [DebuggerDisplay("Name={Name}, Features={Features.Count}, OutputDirectory={OutputDirectory}")]
    public class Project : IProject
    {
        public Project()
        {
        }

        public string Name { get; set; }

        public Database Database { get; set; }

        public string OutputDirectory { get; set; }

        public ProjectFeature this[int index]
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
        private List<ProjectFeature> m_features;

        public List<ProjectFeature> Features
        {
            get
            {
                return m_features ?? (m_features = new List<ProjectFeature>());
            }
            set
            {
                m_features = value;
            }
        }

        public virtual void AddFeature(ProjectFeature projectFeature)
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
                var list = Database
                    .DbObjects
                    .Select(item => item.Schema)
                    .Distinct()
                    .Select(schema => new ProjectFeature { Name = schema, DbObjects = Database.GetDbObjectsBySchema(schema), Project = this })
                    .ToList();

                Features.AddRange(list);
            }
        }
    }
}
