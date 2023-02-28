﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Logging;

namespace CatFactory.Diagnostics
{
    /// <summary>
    /// Represents a validation result
    /// </summary>
    [DebuggerDisplay("IsValid={IsValid}, ValidationMessages={ValidationMessages.Count}")]
    public class ValidationResult
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ValidationMessage> m_validationMessages;

        /// <summary>
        /// Initializes a new instance of <see cref="ValidationResult"/> class
        /// </summary>
        public ValidationResult()
        {
        }

        /// <summary>
        /// Gets or sets the validation messages for current validation result
        /// </summary>
        public List<ValidationMessage> ValidationMessages
        {
            get => m_validationMessages ??= new List<ValidationMessage>();
            set => m_validationMessages = value;
        }

        /// <summary>
        /// Indicates if the current validation result is valid
        /// </summary>
        public virtual bool IsValid
            => ValidationMessages.Count(item => item.LogLevel == LogLevel.Error || item.LogLevel == LogLevel.Critical) == 0;

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>A <see cref="string"/> that represents the current object</returns>
        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var item in ValidationMessages)
            {
                result.AppendLine(string.Format("{0}: {1}", item.LogLevel, item.Message));
            }

            return result.ToString();
        }
    }
}
