using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;
using CatFactory.ObjectRelationalMapping;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Represents a feature for project
    /// </summary>
    /// <typeparam name="TProjectSettings">Settings for project</typeparam>
    [DebuggerDisplay("Name={Name}, Description={Description}, DbObjects={DbObjects.Count}")]
    public class ProjectFeature<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IDbObject> m_dbObjects;

        /// <summary>
        /// Initializes a new instance of <see cref="ProjectFeature{TProjectSettings}"/> class
        /// </summary>
        public ProjectFeature()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ProjectFeature{TProjectSettings}"/> class
        /// </summary>
        /// <param name="name">Feature name</param>
        public ProjectFeature(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ProjectFeature{TProjectSettings}"/> class
        /// </summary>
        /// <param name="name">Feature name</param>
        /// <param name="dbObjects">Sequence of <see cref="IDbObject"/> for the feature</param>
        public ProjectFeature(string name, IEnumerable<IDbObject> dbObjects)
        {
            Name = name;
            DbObjects.AddRange(dbObjects);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ProjectFeature{TProjectSettings}"/> class
        /// </summary>
        /// <param name="name">Feature name</param>
        /// <param name="dbObjects">Sequence of <see cref="IDbObject"/> for the feature</param>
        /// <param name="project">Project to which it belongs</param>
        public ProjectFeature(string name, IEnumerable<IDbObject> dbObjects, IProject<TProjectSettings> project)
        {
            Name = name;
            DbObjects.AddRange(dbObjects);
            Project = project;
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the database objects
        /// </summary>
        public List<IDbObject> DbObjects
        {
            get => m_dbObjects ??= new List<IDbObject>();
            set => m_dbObjects = value;
        }

        /// <summary>
        /// Gets or sets the project
        /// </summary>
        [XmlIgnore]
        public IProject<TProjectSettings> Project { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }
    }
}
