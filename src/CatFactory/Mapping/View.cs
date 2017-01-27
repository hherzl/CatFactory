using System;
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

        public String Schema { get; set; }

        public String Name { get; set; }

        public String FullName
            => String.IsNullOrEmpty(Schema) ? Name : String.Format("{0}.{1}", Schema, Name);

        public String Description { get; set; }

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
    }
}
