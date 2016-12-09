using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class View : IView
    {
        public View()
        {

        }

        public String Schema { get; set; }

        public String Name { get; set; }

        public String FullName
        {
            get
            {
                return String.IsNullOrEmpty(Schema) ? Name : String.Format("{0}.{1}", Schema, Name);
            }
        }

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
