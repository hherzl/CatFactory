using System.Collections.Generic;
using System.Threading.Tasks;
using CatFactory.ObjectOrientedProgramming;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents the abstract model to define a code builder
    /// </summary>
    public interface ICodeBuilder
    {
        /// <summary>
        /// Occurs when the object definition has been translated
        /// </summary>
        event TranslatedDefinition TranslatedDefinition;

        /// <summary>
        /// Gets or sets the tab
        /// </summary>
        string Tab { get; set; }

        /// <summary>
        /// Gets a string that contains tab according to count
        /// </summary>
        /// <param name="count">Quantity of sequence</param>
        /// <returns>A <see cref="string"/> that contains tab according to quantity</returns>
        string Indent(int count);

        /// <summary>
        /// Gets the file name
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// Gets the file extension
        /// </summary>
        string FileExtension { get; }

        /// <summary>
        /// Gets the file path (name + extension)
        /// </summary>
        string FilePath { get; }

        /// <summary>
        /// Gets or sets the object definition for current code builder
        /// </summary>
        IObjectDefinition ObjectDefinition { get; set; }

        /// <summary>
        /// Translates object definition to code lines
        /// </summary>
        void Translating();

        /// <summary>
        /// Gets or sets the code lines for current code builder
        /// </summary>
        List<ILine> Lines { get; set; }

        /// <summary>
        /// Gets or sets the output directory
        /// </summary>
        string OutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets a flag that indicates if code builder must to force overwrite
        /// </summary>
        bool ForceOverwrite { get; set; }

        /// <summary>
        /// Creates the output directory for code file
        /// </summary>
        void CreateOutputDirectory();

        /// <summary>
        /// Creates the code file in output directory
        /// </summary>
        /// <param name="subdirectory">Subdirectory name</param>
        /// <param name="fileName">File name</param>
        void CreateFile(string subdirectory = "", string fileName = "");

        /// <summary>
        /// Creates the code file in output directory
        /// </summary>
        /// <param name="subdirectory">Subdirectory name</param>
        /// <param name="fileName">File name</param>
        Task CreateFileAsync(string subdirectory = "", string fileName = "");
    }
}
