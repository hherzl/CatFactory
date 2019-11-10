using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.ObjectRelationalMapping;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Object in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}")]
    public class ObjectDefinition : IObjectDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_namespaces;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<EventDefinition> m_events;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<PropertyDefinition> m_properties;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MethodDefinition> m_methods;

        /// <summary>
        /// Initializes a new instance of <see cref="ObjectDefinition"/> class
        /// </summary>
        public ObjectDefinition()
        {
            TypeManager.Register(this);
        }

        /// <summary>
        /// Gets or sets the namespaces for current object definition
        /// </summary>
        public List<string> Namespaces
        {
            get => m_namespaces ?? (m_namespaces = new List<string>());
            set => m_namespaces = value;
        }

        /// <summary>
        /// Gets or sets the namespace for current object definition
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the XML documentation comments for current object definition
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ?? (m_documentation = new Documentation());
            set => m_documentation = value;
        }

        /// <summary>
        /// Gets or sets the access modifier for current object definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Indicates if current object definition is partial
        /// </summary>
        public bool IsPartial { get; set; }

        /// <summary>
        /// Gets or sets the name for current object definition
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the full name (Namespace.Name) for current object definition
        /// </summary>
        public virtual string FullName
            => string.IsNullOrEmpty(Namespace) ? Name : string.Format("{0}.{1}", Namespace, Name);

        /// <summary>
        /// Gets or sets the DB object
        /// </summary>
        public IDbObject DbObject { get; set; }

        /// <summary>
        /// Indicates if current object definition has inheritance
        /// </summary>
        public virtual bool HasInheritance
            => false;

        /// <summary>
        /// Gets or sets the metadata attributes for current object definition
        /// </summary>
        public List<MetadataAttribute> Attributes
        {
            get => m_attributes ?? (m_attributes = new List<MetadataAttribute>());
            set => m_attributes = value;
        }

        /// <summary>
        /// Gets or sets the events for current object definition
        /// </summary>
        public List<EventDefinition> Events
        {
            get => m_events ?? (m_events = new List<EventDefinition>());
            set => m_events = value;
        }

        /// <summary>
        /// Gets or sets the properties for current object definition
        /// </summary>
        public List<PropertyDefinition> Properties
        {
            get => m_properties ?? (m_properties = new List<PropertyDefinition>());
            set => m_properties = value;
        }

        /// <summary>
        /// Gets or sets the methods for current object definition
        /// </summary>
        public List<MethodDefinition> Methods
        {
            get => m_methods ?? (m_methods = new List<MethodDefinition>());
            set => m_methods = value;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(object obj)
            => (obj is ObjectDefinition cast && FullName == cast.FullName) ? true : false;

        /// <summary>
        /// Gets the hash code for current object.
        /// </summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
            => base.GetHashCode();
    }
}
