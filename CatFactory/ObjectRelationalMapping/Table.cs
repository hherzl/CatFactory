using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Xml.Serialization;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents an user table
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class Table : DbObject, ITable
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Index> m_indexes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ForeignKey> m_foreignKeys;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Unique> m_uniques;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Check> m_checks;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Default> m_defaults;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private dynamic m_importBag;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Table"/> class
        /// </summary>
        public Table()
            : base()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
        public List<Column> Columns
        {
            get => m_columns ?? (m_columns = new List<Column>());
            set => m_columns = value;
        }

        #endregion

        #region [ Indexers ]

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index">Column index</param>
        /// <returns>A <see cref="Column"/> from current table</returns>
        public Column this[int index]
        {
            get => Columns[index];
            set => Columns[index] = value;
        }

        /// <summary>
        /// Gets or sets a column by name
        /// </summary>
        /// <param name="name">Column name</param>
        /// <returns>A <see cref="Column"/> from current table</returns>
        public Column this[string name]
        {
            get => Columns.First(item => item.Name == name);
            set
            {
                for (var i = 0; i < Columns.Count; i++)
                {
                    var column = Columns[i];

                    if (column.Name == name)
                        column = value;
                }
            }
        }

        #endregion

        #region [ Members of ITable ]

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        [Obsolete("Save description as extended property")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets indexes list
        /// </summary>
        public List<Index> Indexes
        {
            get => m_indexes ?? (m_indexes = new List<Index>());
            set => m_indexes = value;
        }

        /// <summary>
        /// Gets or sets primary key
        /// </summary>
        public PrimaryKey PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets foreign key constraints
        /// </summary>
        public List<ForeignKey> ForeignKeys
        {
            get => m_foreignKeys ?? (m_foreignKeys = new List<ForeignKey>());
            set => m_foreignKeys = value;
        }

        /// <summary>
        /// Gets or sets unique constraints
        /// </summary>
        public List<Unique> Uniques
        {
            get => m_uniques ?? (m_uniques = new List<Unique>());
            set => m_uniques = value;
        }

        /// <summary>
        /// Gets or sets check constraints
        /// </summary>
        public List<Check> Checks
        {
            get => m_checks ?? (m_checks = new List<Check>());
            set => m_checks = value;
        }

        /// <summary>
        /// Gets or sets default constraints
        /// </summary>
        public List<Default> Defaults
        {
            get => m_defaults ?? (m_defaults = new List<Default>());
            set => m_defaults = value;
        }

        /// <summary>
        /// Gets or sets the extension data for import
        /// </summary>
        [XmlIgnore]
        public dynamic ImportBag
        {
            get => m_importBag ?? (m_importBag = new ExpandoObject());
            set => m_importBag = value;
        }

        #endregion
    }
}
