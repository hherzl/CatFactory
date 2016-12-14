using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class Procedure
    {
        public Procedure()
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

        private List<ProcedureParameter> m_parameters;

        public List<ProcedureParameter> Parameters
        {
            get
            {
                return m_parameters ?? (m_parameters = new List<ProcedureParameter>());
            }
            set
            {
                m_parameters = value;
            }
        }
    }
}
