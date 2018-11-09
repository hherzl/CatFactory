using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Remarks={Remarks}")]
    public class Documentation
    {
        /// <summary>
        /// 
        /// </summary>
        public Documentation()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasRemarks
            => !string.IsNullOrEmpty(Remarks);

        /// <summary>
        /// 
        /// </summary>
        public string Returns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasReturns
            => !string.IsNullOrEmpty(Returns);

        /// <summary>
        /// 
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasSummary
            => !string.IsNullOrEmpty(Summary);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<dynamic> m_customTags;

        /// <summary>
        /// 
        /// </summary>
        public List<dynamic> CustomTags
        {
            get
            {
                return m_customTags ?? (m_customTags = new List<dynamic>());
            }
            set
            {
                m_customTags = value;
            }
        }
    }
}
