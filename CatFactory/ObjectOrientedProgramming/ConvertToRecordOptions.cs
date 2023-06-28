namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Provides options for convert a class definition in record definition
    /// </summary>
    public record ConvertToRecordOptions
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ConvertToRecordOptions"/> record
        /// </summary>
        /// <param name="includeFields">Include fields</param>
        public ConvertToRecordOptions(bool includeFields = false)
        {
            IncludeProperties = true;
            IncludeFields = includeFields;
        }

        /// <summary>
        /// Indicates if properties are included 
        /// </summary>
        public bool IncludeProperties { get; set; }

        /// <summary>
        /// Indicates if fields are included 
        /// </summary>
        public bool IncludeFields { get; set; }

        /// <summary>
        /// Indicates if methods are included 
        /// </summary>
        public bool IncludeMethods { get; set; }
    }
}
