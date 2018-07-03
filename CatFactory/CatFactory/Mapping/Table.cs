using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents an user table
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class Table : DbObject, ITable
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Table"/> class
        /// </summary>
        public Table()
        {
        }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index">Column's index</param>
        /// <returns>A <see cref="CatFactory.Mapping.Column"/> from current table</returns>
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
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
        /// Gets or sets row Guid column
        /// </summary>
        public RowGuidCol RowGuidCol { get; set; }

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets primary key
        /// </summary>
        public PrimaryKey PrimaryKey { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ForeignKey> m_foreignKeys;

        /// <summary>
        /// Gets or sets foreign keys constraints
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableReference> m_tableReferences;

        /// <summary>
        /// Gets or sets references for table
        /// </summary>
        public List<TableReference> TableReferences
        {
            get
            {
                return m_tableReferences ?? (m_tableReferences = new List<TableReference>());
            }
            set
            {
                m_tableReferences = value;
            }
        }
    }
}
