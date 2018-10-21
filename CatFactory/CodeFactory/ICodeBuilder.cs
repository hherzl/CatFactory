using System.Collections.Generic;
using CatFactory.ObjectOrientedProgramming;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICodeBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        string Tab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        string Indent(int count);

        /// <summary>
        /// 
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// 
        /// </summary>
        string FileExtension { get; }

        /// <summary>
        /// 
        /// </summary>
        string FilePath { get; }

        /// <summary>
        /// 
        /// </summary>
        IObjectDefinition ObjectDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        void Translating();

        /// <summary>
        /// 
        /// </summary>
        List<ILine> Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        event TranslatedDefinition TranslatedDefinition;

        /// <summary>
        /// 
        /// </summary>
        string OutputDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool ForceOverwrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        void CreateOutputDirectory();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subdirectory"></param>
        /// <param name="fileName"></param>
        void CreateFile(string subdirectory = "", string fileName = "");
    }
}
