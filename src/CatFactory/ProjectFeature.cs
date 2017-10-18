using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;
using CatFactory.Mapping;

namespace CatFactory
{
    [DebuggerDisplay("Name={Name}, DbObjects={DbObjects.Count}, Description={Description}")]
    public class ProjectFeature
    {
        public ProjectFeature()
        {
        }

        public ProjectFeature(string name)
        {
            Name = name;
        }

        public ProjectFeature(string name, IEnumerable<DbObject> dbObjects)
        {
            Name = name;
            DbObjects.AddRange(dbObjects);
        }

        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<DbObject> m_dbObjects;

        public List<DbObject> DbObjects
        {
            get
            {
                return m_dbObjects ?? (m_dbObjects = new List<DbObject>());
            }
            set
            {
                m_dbObjects = value;
            }
        }

        [XmlIgnore]
        public Project Project { get; set; }

        public string Description { get; set; }
    }
}
