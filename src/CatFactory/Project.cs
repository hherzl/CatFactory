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

        public List<ProjectFeature> Features { get; set; }

        public String OutputDirectory { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<String> m_addExclusions;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<String> m_updateExclusions;

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

        public virtual void BuildFeatures()
        {
            if (Database == null)
            {
                return;
            }

            Features = Database
                .DbObjects
                .Select(item => item.Schema)
                .Distinct()
                .Select(item => new ProjectFeature(item, Database.DbObjects.Where(db => db.Schema == item).ToList(), Database))
                .ToList();
        }

        public virtual IDbObject FindObject(String fullName)
        {
            var dbObj = Database.DbObjects.FirstOrDefault(item => item.FullName == String.Format("{0}.{1}", Database.Name, fullName));

            if (dbObj == null)
            {
                dbObj = Database.DbObjects.FirstOrDefault(item => item.FullName == fullName);
            }

            return dbObj;
        }

        public virtual ITable FindTable(String fullName)
        {
            var table = Database.Tables.FirstOrDefault(item => item.FullName == String.Format("{0}.{1}", Database.Name, fullName));

            if (table == null)
            {
                table = Database.Tables.FirstOrDefault(item => item.FullName == fullName);
            }

            return table;
        }
    }
}
