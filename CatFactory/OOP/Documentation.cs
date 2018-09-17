namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
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
        public string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasSummary
            => !string.IsNullOrEmpty(Summary);

        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasRemarks
            => !string.IsNullOrEmpty(Remarks);
    }
}
