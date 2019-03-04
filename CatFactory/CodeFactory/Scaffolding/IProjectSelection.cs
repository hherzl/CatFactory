namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Provides an abstract model for project selection
    /// </summary>
    /// <typeparam name="TProjectSettings">Settings for project</typeparam>
    public interface IProjectSelection<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        /// <summary>
        /// Gets or sets the pattern
        /// </summary>
        string Pattern { get; set; }

        /// <summary>
        /// Indicates if selection is global (*.*)
        /// </summary>
        bool IsGlobal { get; }

        /// <summary>
        /// Gets or sets the settings
        /// </summary>
        TProjectSettings Settings { get; set; }
    }
}
