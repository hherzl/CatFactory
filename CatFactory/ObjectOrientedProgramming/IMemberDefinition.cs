namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMemberDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Name { get; set; }
    }
}
