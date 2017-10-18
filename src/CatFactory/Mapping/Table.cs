using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class Table : ITable
    {
        public Table()
        {
        }

        public string Schema { get; set; }

        public string Name { get; set; }

        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        public string Type { get; set; }

        public string Description { get; set; }

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

        public Identity Identity { get; set; }

        public PrimaryKey PrimaryKey { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ForeignKey> m_foreignKeys;

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
