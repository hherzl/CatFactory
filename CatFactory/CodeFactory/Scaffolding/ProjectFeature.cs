using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;
using CatFactory.ObjectRelationalMapping;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProjectSettings"></typeparam>
    [DebuggerDisplay("Name={Name}, Description={Description}, DbObjects={DbObjects.Count}")]
    public class ProjectFeature<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        /// <summary>
        /// 
        /// </summary>
        public ProjectFeature()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public ProjectFeature(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dbObjects"></param>
        public ProjectFeature(string name, IEnumerable<IDbObject> dbObjects)
        {
            Name = name;
            DbObjects.AddRange(dbObjects);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dbObjects"></param>
        /// <param name="project"></param>
        public ProjectFeature(string name, IEnumerable<IDbObject> dbObjects, IProject<TProjectSettings> project)
        {
            Name = name;
            DbObjects.AddRange(dbObjects);
            Project = project;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IDbObject> m_dbObjects;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public IProject<TProjectSettings> Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
    }
}
