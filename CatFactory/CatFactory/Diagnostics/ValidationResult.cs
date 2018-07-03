using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace CatFactory.Diagnostics
{
    /// <summary>
    /// Represents a validation result
    /// </summary>
    [DebuggerDisplay("IsValid={IsValid}, ValidationMessages={ValidationMessages.Count}")]
    public class ValidationResult
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ValidationResult"/> class
        /// </summary>
        public ValidationResult()
        {
        }

        /// <summary>
        /// Indicates if the current validation result is valid
        /// </summary>
        public virtual bool IsValid
            => ValidationMessages.Where(item => item.LogLevel == LogLevel.Error || item.LogLevel == LogLevel.Critical).Count() == 0 ? true : false;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ValidationMessage> m_validationMessages;

        /// <summary>
        /// Gets or sets the validation messages for current validation result
        /// </summary>
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
