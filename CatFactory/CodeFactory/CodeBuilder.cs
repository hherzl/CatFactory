using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CatFactory.Collections;
using CatFactory.OOP;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class CodeBuilder : ICodeBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        protected ILogger Logger;

        /// <summary>
        /// 
        /// </summary>
        public CodeBuilder()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public CodeBuilder(ILogger<ICodeBuilder> logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Tab { get; set; } = "\t";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public string Indent(int count)
            => string.Concat(Enumerable.Repeat(Tab, count));

        /// <summary>
        /// 
        /// </summary>
        public virtual string FileName
            => string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public virtual string FileExtension
            => string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public virtual string FilePath
            => string.Format("{0}.{1}", FileName, FileExtension);

        /// <summary>
        /// 
        /// </summary>
        public IObjectDefinition ObjectDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Translating()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// 
        /// </summary>
        public List<ILine> Lines
        {
            get
            {
                return m_lines ?? (m_lines = new List<ILine>());
            }
            set
            {
                m_lines = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public event TranslatedDefinition TranslatedDefinition;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        protected void OnTranslatedDefinition(TranslatedDefinitionEventArgs args)
        {
            TranslatedDefinition?.Invoke(this, args);
        }

        /// <summary>
        /// 
        /// </summary>
        public string OutputDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ForceOverwrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual void CreateOutputDirectory()
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(CreateOutputDirectory));

            if (!Directory.Exists(OutputDirectory))
            {
                Logger?.LogInformation("Creating '{0}' directory...", OutputDirectory);

                Directory.CreateDirectory(OutputDirectory);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subdirectory"></param>
        /// <param name="fileName"></param>
        public virtual void CreateFile(string subdirectory = "", string fileName = "")
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(CreateFile));

            CreateOutputDirectory();

            var filePath = string.IsNullOrEmpty(fileName) ? Path.Combine(OutputDirectory, subdirectory, FilePath) : Path.Combine(OutputDirectory, subdirectory, fileName);

            if (!ForceOverwrite && File.Exists(filePath))
                throw new CodeFactoryException(string.Format("The '{0}' file alread exists, if you want to overwrite set ForceOverwrite property as true", filePath));

            if (!string.IsNullOrEmpty(subdirectory))
            {
                var subdirectoryPath = Path.Combine(OutputDirectory, subdirectory);

                if (!Directory.Exists(subdirectoryPath))
                {
                    Logger?.LogInformation("Creating '{0}' directory...", subdirectoryPath);

                    Directory.CreateDirectory(subdirectoryPath);
                }
            }

            Logger?.LogInformation("Creating '{0}' file...", filePath);

            Translating();

            OnTranslatedDefinition(new TranslatedDefinitionEventArgs(Logger));

            File.WriteAllText(filePath, Lines.ToStringBuilder().ToString());
        }
    }
}
