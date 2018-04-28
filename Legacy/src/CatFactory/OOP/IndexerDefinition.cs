using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    public class IndexerDefinition : IMemberDefinition
    {
        public IndexerDefinition()
        {
        }

        public AccessModifier AccessModifier { get; set; }

        public string Type { get; set; }

        public string Name { get; set; } = "this";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ParameterDefinition> m_parameters;

        public List<ParameterDefinition> Parameters
        {
            get
            {
                return m_parameters ?? (m_parameters = new List<ParameterDefinition>());
            }
            set
            {
                m_parameters = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_getBody;

        public List<ILine> GetBody
        {
            get
            {
                return m_getBody ?? (m_getBody = new List<ILine>());
            }
            set
            {
                m_getBody = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_setBody;

        public List<ILine> SetBody
        {
            get
            {
                return m_setBody ?? (m_setBody = new List<ILine>());
            }
            set
            {
                m_setBody = value;
            }
        }
    }
}
