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

        public String Tab { get; set; } = "\t";

        public String Indent(Int32 count)
            => String.Concat(Enumerable.Repeat(Tab, count));

        public virtual String FileName
            => String.Empty;

        public virtual String FileExtension
            => String.Empty;

        public virtual String FullFileName
            => String.Format("{0}.{1}", FileName, FileExtension);

        public INamingConvention NamingConvention { get; set; }

        protected virtual String GetComment(String description)
        {
            return description;
        }

        public virtual String Code => String.Empty;

        public String OutputDirectory { get; set; }

        public virtual void CreateOutputDirectory()
        {
            if (!Directory.Exists(OutputDirectory))
            {
                Directory.CreateDirectory(OutputDirectory);
            }
        }

        public virtual void CreateFile(String subdirectory = "", String fileName = "")
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

            if (String.IsNullOrEmpty(fileName))
            {
                TextFileHelper.CreateFile(Path.Combine(OutputDirectory, subdirectory, FullFileName), Code);
            }
            else
            {
                TextFileHelper.CreateFile(Path.Combine(OutputDirectory, subdirectory, fileName), Code);
            }
        }
    }
}
