using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CatFactory.Mapping;

namespace CatFactory
{
    [DebuggerDisplay("Name={Name}, Features={Features.Count}")]
    public class Project : IProject
    {
        public Project()
        {
        }

        public String Name { get; set; }

        public Database Database { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<String> m_addExclusions;

        public List<String> AddExclusions
        {
            get
            {
                return m_addExclusions ?? (m_addExclusions = new List<String>());
            }
            set
            {
                m_addExclusions = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<String> m_updateExclusions;

        public List<String> UpdateExclusions
        {
            get
            {
                return m_updateExclusions ?? (m_updateExclusions = new List<String>());
            }
            set
            {
                m_updateExclusions = value;
            }
        }

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
                Features.AddRange(Database
                    .DbObjects
                    .Select(item => item.Schema)
                    .Distinct()
                    .Select(item => new ProjectFeature(item, Database.DbObjects.Where(db => db.Schema == item).ToList()) { Project = this })
                    .ToList());
            }
            else if (Database.Tables.Count > 0)
            {
                Features.AddRange(Database
                    .Tables
                    .Select(item => item.Schema)
                    .Distinct()
                    .Select(item => new ProjectFeature(item, Database.DbObjects.Where(db => db.Schema == item).ToList()) { Project = this })
                    .ToList());
            }
            else if (Database.Views.Count > 0)
            {
                Features.AddRange(Database
                    .Views
                    .Select(item => item.Schema)
                    .Distinct()
                    .Select(item => new ProjectFeature(item, Database.DbObjects.Where(db => db.Schema == item).ToList()) { Project = this })
                    .ToList());
            }
        }

        public String OutputDirectory { get; set; }
    }
}
