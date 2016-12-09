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

        public virtual void CreateOutputDirectory(String targetDirectory)
        {
            if (String.IsNullOrEmpty(targetDirectory))
            {
                targetDirectory = OutputDirectory;
            }

            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }
        }

        public virtual void CreateFile(String targetDirectory)
        {
            CreateOutputDirectory(targetDirectory);

            TextFileHelper.CreateFile(Path.Combine(targetDirectory, FullFileName), Code);
        }
    }
}
