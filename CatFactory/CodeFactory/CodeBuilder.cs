using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CatFactory.Collections;
using CatFactory.ObjectOrientedProgramming;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a code builder
    /// </summary>
    public class CodeBuilder : ICodeBuilder
    {
        /// <summary>
        /// Occurs when the object definition has been translated
        /// </summary>
        public event TranslatedDefinition TranslatedDefinition;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// Initializes a new instance of <see cref="CodeBuilder"/> class
        /// </summary>
        public CodeBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CodeBuilder"/> class
        /// </summary>
        /// <param name="logger">Instance of <see cref="Logger"/> class</param>
        public CodeBuilder(ILogger<ICodeBuilder> logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Gets the <see cref="Logger"/> instance for current <see cref="CodeBuilder"/> instance
        /// </summary>
        protected ILogger Logger { get; }

        /// <summary>
        /// Gets or sets the tab
        /// </summary>
        public string Tab { get; set; } = "\t";

        /// <summary>
        /// Gets a <see cref="string"/> that contains indentation character
        /// </summary>
        /// <param name="count">Quantity of sequence</param>
        /// <returns>A <see cref="string"/> that contains indentation character</returns>
        public string Indent(int count)
            => string.Concat(Enumerable.Repeat(Tab, count));

        /// <summary>
        /// Gets the file name
        /// </summary>
        public virtual string FileName
            => string.Empty;

        /// <summary>
        /// Gets the file extension
        /// </summary>
        public virtual string FileExtension
            => string.Empty;

        /// <summary>
        /// Gets the file path (name + extension)
        /// </summary>
        public virtual string FilePath
            => string.Format("{0}.{1}", FileName, FileExtension);

        /// <summary>
        /// Gets or sets the object definition for current code builder
        /// </summary>
        public IObjectDefinition ObjectDefinition { get; set; }

        /// <summary>
        /// Translates object definition to code lines
        /// </summary>
        public virtual void Translating()
        {
        }

        /// <summary>
        /// Gets or sets the code lines for current code builder
        /// </summary>
        public List<ILine> Lines
        {
            get => m_lines ??= new List<ILine>();
            set => m_lines = value;
        }

        /// <summary>
        /// Gets or sets the output directory
        /// </summary>
        public string OutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets a flag that indicates if code builder must to force overwrite
        /// </summary>
        public bool ForceOverwrite { get; set; }

        /// <summary>
        /// Raises the <see cref="TranslatedDefinition"/> event
        /// </summary>
        /// <param name="args">Data for <see cref="TranslatedDefinition"/> class</param>
        protected void OnTranslatedDefinition(TranslatedDefinitionEventArgs args)
        {
            TranslatedDefinition?.Invoke(this, args);
        }

        /// <summary>
        /// Creates the output directory for code file
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
        /// Creates the code file in output directory
        /// </summary>
        /// <param name="subdirectory">Subdirectory name</param>
        /// <param name="fileName">File name</param>
        public virtual void CreateFile(string subdirectory = "", string fileName = "")
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(CreateFile));

            CreateOutputDirectory();

            var filePath = string.IsNullOrEmpty(fileName) ? Path.Combine(OutputDirectory, subdirectory, FilePath) : Path.Combine(OutputDirectory, subdirectory, fileName);

            if (!ForceOverwrite && File.Exists(filePath))
                throw new CodeFactoryException(string.Format("The '{0}' file already exists, if you want to overwrite it, set ForceOverwrite property as true", filePath));

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

        /// <summary>
        /// Creates the code file in output directory
        /// </summary>
        /// <param name="subdirectory">Subdirectory name</param>
        /// <param name="fileName">File name</param>
        public virtual async Task CreateFileAsync(string subdirectory = "", string fileName = "")
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(CreateFile));

            CreateOutputDirectory();

            var filePath = string.IsNullOrEmpty(fileName) ? Path.Combine(OutputDirectory, subdirectory, FilePath) : Path.Combine(OutputDirectory, subdirectory, fileName);

            if (!ForceOverwrite && File.Exists(filePath))
                throw new CodeFactoryException(string.Format("The '{0}' file already exists, if you want to overwrite it, set ForceOverwrite property as true", filePath));

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

            await File.WriteAllTextAsync(filePath, Lines.ToStringBuilder().ToString());
        }
    }
}
