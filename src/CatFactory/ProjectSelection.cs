using System.Diagnostics;

namespace CatFactory
{
    public class ProjectSelection<TProjectSettings> : IProjectSelection<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
        public const string GlobalPattern = "*.*";

        public string Pattern { get; set; }

        public bool IsGlobal
            => Pattern == GlobalPattern;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TProjectSettings m_settings;

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
