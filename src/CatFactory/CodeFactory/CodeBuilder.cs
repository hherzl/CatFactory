using System;
using System.IO;
using System.Linq;

namespace CatFactory.CodeFactory
{
    public class CodeBuilder
    {
        public CodeBuilder()
        {
        }

        public String OutputDirectory { get; set; }

        public String Tab { get; set; } = "\t";

        public String Indent(Int32 count)
        {
            return String.Concat(Enumerable.Repeat(Tab, count));
        }

        public virtual String FileName
        {
            get
            {
                return String.Empty;
            }
        }

        public virtual String FileExtension
        {
            get
            {
                return String.Empty;
            }
        }

        public virtual String Code
        {
            get
            {
                return String.Empty;
            }
        }

        public virtual String FullFileName
        {
            get
            {
                return String.Format("{0}.{1}", FileName, FileExtension);
            }
        }

        public virtual void CreateOutputDirectory()
        {
            if (!Directory.Exists(OutputDirectory))
            {
                Directory.CreateDirectory(OutputDirectory);
            }
        }

        public virtual void CreateFile(String subdirectory = "")
        {
            CreateOutputDirectory();

            if (!String.IsNullOrEmpty(subdirectory))
            {
                var subdirectoryPath = Path.Combine(OutputDirectory, subdirectory);

                if (!Directory.Exists(subdirectoryPath))
                {
                    Directory.CreateDirectory(subdirectoryPath);
                }
            }

            TextFileHelper.CreateFile(Path.Combine(OutputDirectory, subdirectory, FullFileName), Code);
        }
    }
}
