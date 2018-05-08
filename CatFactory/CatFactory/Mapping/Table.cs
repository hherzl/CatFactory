using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents an user table
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class Table : ITable
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.Table"/> class
        /// </summary>
        public Table()
        {
        }

        /// <summary>
        /// Gets or sets the schema
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets full name
        /// </summary>
        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Column this[int index]
        {
            get
            {
                return Columns[index];
            }
            set
            {
                Columns[index] = value;
            }
        }

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        public List<Column> Columns
        {
            get
            {
                return m_columns ?? (m_columns = new List<Column>());
            }
            set
            {
                m_columns = value;
            }
        }

        /// <summary>
        /// Gets or sets identity (auto incremental)
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets row Guid column
        /// </summary>
        public RowGuidCol RowGuidCol { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Index> m_indexes;

        /// <summary>
        /// Gets or sets indexes list
        /// </summary>
        public List<Index> Indexes
        {
            get
            {
                return m_indexes ?? (m_indexes = new List<Index>());
            }
            set
            {
                m_indexes = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ConstraintDetail> m_constraintDetails;

        /// <summary>
        /// Gets or sets details for constraints
        /// </summary>
        public List<ConstraintDetail> ConstraintDetails
        {
            get
            {
                return m_constraintDetails ?? (m_constraintDetails = new List<ConstraintDetail>());
            }
            set
            {
                m_constraintDetails = value;
            }
        }

        /// <summary>
        /// Gets or sets primary key
        /// </summary>
        public PrimaryKey PrimaryKey { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Unique> m_uniques;

        /// <summary>
        /// Gets or sets unique constraints
        /// </summary>
        public List<Unique> Uniques
        {
            get
            {
                return m_uniques ?? (m_uniques = new List<Unique>());
            }
            set
            {
                m_uniques = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ForeignKey> m_foreignKeys;

        /// <summary>
        /// Gets or sets foreign key constraint
        /// </summary>
        public List<ForeignKey> ForeignKeys
        {
            get
            {
                return m_foreignKeys ?? (m_foreignKeys = new List<ForeignKey>());
            }
            set
            {
                m_foreignKeys = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Check> m_checks;

        /// <summary>
        /// Gets or sets check constraints
        /// </summary>
        public List<Check> Checks
        {
            get
            {
                return m_checks ?? (m_checks = new List<Check>());
            }
            set
            {
                m_checks = value;
            }
        }
    }
}
