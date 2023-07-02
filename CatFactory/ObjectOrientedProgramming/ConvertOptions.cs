namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Provides options for convert definitions
    /// </summary>
    public record ConvertOptions
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ConvertOptions"/> record
        /// </summary>
        /// <param name="includeFields">Include fields</param>
        /// <param name="useAutomaticProperties">Use automatic properties</param>
        /// <param name="convertPropertiesAsFields">Convert properties as fields</param>
        public ConvertOptions(bool includeFields = false, bool useAutomaticProperties = true, bool convertPropertiesAsFields = false)
        {
            IncludeFields = includeFields;
            IncludeProperties = true;
            UseAutomaticProperties = useAutomaticProperties;
            ConvertPropertiesAsFields = convertPropertiesAsFields;
        }

        /// <summary>
        /// Indicates if fields are included 
        /// </summary>
        public bool IncludeFields { get; set; }

        /// <summary>
        /// Indicates if properties are included 
        /// </summary>
        public bool IncludeProperties { get; set; }

        /// <summary>
        /// Indicates if methods are included 
        /// </summary>
        public bool IncludeMethods { get; set; }

        /// <summary>
        /// Indicates if output definition will use automatic properties
        /// </summary>
        public bool UseAutomaticProperties { get; set; }

        /// <summary>
        /// Indicates if properties will convert as fields in output definition
        /// </summary>
        public bool ConvertPropertiesAsFields { get; set; }

        /// <summary>
        /// Indicates if ourput definition will declare properties as positional (record)
        /// </summary>
        public bool DeclarePropertiesAsPositionals { get; set; }

        /// <summary>
        /// Gets or sets the exclusions in convert process
        /// </summary>
        public string[] Exclusions { get; set; }
    }
}
