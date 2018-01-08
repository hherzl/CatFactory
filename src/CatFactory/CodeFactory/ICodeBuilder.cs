using System.Collections.Generic;
using CatFactory.OOP;

namespace CatFactory.CodeFactory
{
    public interface ICodeBuilder
    {
        string Tab { get; set; }

        string Indent(int count);

        string FileName { get; }

        string FileExtension { get; }

        string FilePath { get; }

        IObjectDefinition ObjectDefinition { get; set; }

        string Code { get; }

        List<ILine> Lines { get; set; }

        string OutputDirectory { get; set; }

        bool ForceOverwrite { get; set; }

        void CreateOutputDirectory();

        void CreateFile(string subdirectory = "", string fileName = "");
    }
}
