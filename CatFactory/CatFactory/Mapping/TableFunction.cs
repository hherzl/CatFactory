using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class TableFunction : IDbObject
    {
        public TableFunction()
        {
        }

        public string Schema { get; set; }

        public string Name { get; set; }

        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        public string Type { get; set; }

        public string Description { get; set; }

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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Parameter> m_parameters;

        public List<Parameter> Parameters
        {
            get
            {
                return m_parameters ?? (m_parameters = new List<Parameter>());
            }
            set
            {
                m_parameters = value;
            }
        }

        public Identity Identity { get; set; }
    }
}
