using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Diagnostics
{
    public class ValidationResult
    {
        public ValidationResult()
        {
        }

        public bool IsValid { get; set; }

        private List<ValidationMessage> m_validationMessages;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public List<ValidationMessage> ValidationMessages
        {
            get
            {
                return m_validationMessages ?? (m_validationMessages = new List<ValidationMessage>());
            }
            set
            {
                m_validationMessages = value;
            }
        }
    }
}
