using System.Diagnostics;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProjectSettings"></typeparam>
    [DebuggerDisplay("Pattern={Pattern}, IsGlobal={IsGlobal}")]
    public class ProjectSelection<TProjectSettings> : IProjectSelection<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        /// <summary>
        /// 
        /// </summary>
        public const string GlobalPattern = "*.*";

        /// <summary>
        /// 
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsGlobal
            => Pattern == GlobalPattern;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TProjectSettings m_settings;

        /// <summary>
        /// 
        /// </summary>
        public virtual TProjectSettings Settings
        {
            get
            {
                return m_settings ?? (m_settings = new TProjectSettings());
            }
            set
            {
                m_settings = value;
            }
        }
    }
}
