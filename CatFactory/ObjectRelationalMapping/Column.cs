using System.Diagnostics;
using System.Dynamic;
using System.Xml.Serialization;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a column for table, view or table function
    /// </summary>
    [DebuggerDisplay("Name={Name}, Type={Type}, Nullable={Nullable ? \"Yes\": \"No\"}")]
    public class Column : IColumn
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private dynamic m_importBag;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Column"/> class
        /// </summary>
        public Column()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets if column is computed
        /// </summary>
        public string Computed { get; set; }

        /// <summary>
        /// Gets or sets length
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets precision
        /// </summary>
        public short Prec { get; set; }

        /// <summary>
        /// Gets or sets scale
        /// </summary>
        public short Scale { get; set; }

        /// <summary>
        /// Gets or sets if column allows null value
        /// </summary>
        public bool Nullable { get; set; }

        /// <summary>
        /// Gets or sets collation for column
        /// </summary>
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets the default value
        /// </summary>
        public object DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the extension data for import
        /// </summary>
        [XmlIgnore]
        public dynamic ImportBag
        {
            get => m_importBag ??= new ExpandoObject();
            set => m_importBag = value;
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Determines whether the specified object is equal to the current object
        /// </summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
            => obj is Column cast && string.Compare(Name, cast.Name) == 0;

        /// <summary>
        /// Returns the hash code for this column
        /// </summary>
        /// <returns>A 32-bit signed integer hash code</returns>
        public override int GetHashCode()
            => Name == null ? 0 : Name.GetHashCode();

        #endregion
    }
}
