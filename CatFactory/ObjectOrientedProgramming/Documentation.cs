using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for XML Documentation Comments in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("Summary={Summary}, Returns={Returns}")]
    public class Documentation
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<dynamic> m_customTags;

        /// <summary>
        /// Initializes a new instance of <see cref="Documentation"/> class
        /// </summary>
        public Documentation()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Documentation"/> class
        /// </summary>
        /// <param name="summary">Summary</param>
        /// <param name="remarks">Remarks</param>
        /// <param name="returns">Returns</param>
        public Documentation(string summary, string remarks = "", string returns = "")
        {
            Summary = summary;
        }

        /// <summary>
        /// Gets or sets the summary for current documentation
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Indicates if current documentation has summary
        /// </summary>
        public bool HasSummary
            => !string.IsNullOrEmpty(Summary);

        /// <summary>
        /// Gets or sets the remarks for current documentation
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// Indicates if current documentation has remarks
        /// </summary>
        public bool HasRemarks
            => !string.IsNullOrEmpty(Remarks);

        /// <summary>
        /// Gets or sets the returns for current documentation
        /// </summary>
        public string Returns { get; set; }

        /// <summary>
        /// Indicates if current documentation has returns
        /// </summary>
        public bool HasReturns
            => !string.IsNullOrEmpty(Returns);

        /// <summary>
        /// Gets or sets the custom tags for current documentation
        /// </summary>
        public List<dynamic> CustomTags
        {
            get => m_customTags ??= new List<dynamic>();
            set => m_customTags = value;
        }
    }
}
