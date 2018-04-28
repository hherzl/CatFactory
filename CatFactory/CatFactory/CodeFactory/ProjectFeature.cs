using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;
using CatFactory.Mapping;

namespace CatFactory.CodeFactory
{
    [DebuggerDisplay("Name={Name}, Description={Description}, DbObjects={DbObjects.Count}")]
    public class ProjectFeature<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        public ProjectFeature()
        {
        }

        public ProjectFeature(string name)
        {
            Name = name;
        }

        public ProjectFeature(string name, IEnumerable<IDbObject> dbObjects)
        {
            Name = name;
            DbObjects.AddRange(dbObjects);
        }

        public string Name { get; set; }

        public string Description { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IDbObject> m_dbObjects;

        public List<IDbObject> DbObjects
        {
            get
            {
                return m_dbObjects ?? (m_dbObjects = new List<IDbObject>());
            }
            set
            {
                m_dbObjects = value;
            }
        }

        [XmlIgnore]
        public Project<TProjectSettings> Project { get; set; }
    }
}
