using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class ScalarFunction
    {
        public ScalarFunction()
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

        public String Description { get; set; }

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
