using System.Diagnostics;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Represents a selection by pattern for project
    /// </summary>
    /// <typeparam name="TProjectSettings">Settings for project</typeparam>
    [DebuggerDisplay("Pattern={Pattern}, IsGlobal={IsGlobal}")]
    public class ProjectSelection<TProjectSettings> : IProjectSelection<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        /// <summary>
        /// Gets the global pattern for project settings
        /// </summary>
        public const string GlobalPattern = "*.*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TProjectSettings m_settings;

        /// <summary>
        /// Initializes a new instance of <see cref="Project{TProjectSettings}"/> class
        /// </summary>
        public ProjectSelection()
        {
        }

        /// <summary>
        /// Gets or sets the pattern
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Indicates if selection is global (*.*)
        /// </summary>
        public bool IsGlobal
            => Pattern == GlobalPattern;

        /// <summary>
        /// Gets or sets the project settings
        /// </summary>
        public virtual TProjectSettings Settings
        {
            get => m_settings ??= new TProjectSettings();
            set => m_settings = value;
        }
    }
}
