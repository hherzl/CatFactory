using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class View : IView
    {
        public View()
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

        public RowGuidCol RowGuidCol { get; set; }
    }
}
