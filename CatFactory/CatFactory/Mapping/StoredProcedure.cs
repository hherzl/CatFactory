using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class StoredProcedure : IDbObject
    {
        public StoredProcedure()
        {
        }

        public string Schema { get; set; }

        public string Name { get; set; }

        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        public string Type { get; set; }

        public string Description { get; set; }

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
    }
}
