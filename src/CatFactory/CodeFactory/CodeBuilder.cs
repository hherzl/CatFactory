using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    public class CodeBuilder
    {
        protected ILogger Logger;

        public CodeBuilder()
        {
        }

        public CodeBuilder(ILogger logger)
        {
            Logger = logger;
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
            => description;

        public virtual String Code
            => String.Empty;

        protected List<ILine> Lines = new List<ILine>();

        public String OutputDirectory { get; set; }

        public virtual void CreateOutputDirectory()
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(CreateOutputDirectory));

            if (!Directory.Exists(OutputDirectory))
            {
                Directory.CreateDirectory(OutputDirectory);

                Logger?.LogDebug("'{0}' directory has been created", OutputDirectory);
            }
        }

        public virtual void CreateFile(String subdirectory = "", String fileName = "")
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(CreateFile));

            CreateOutputDirectory();

            if (!String.IsNullOrEmpty(subdirectory))
            {
                var subdirectoryPath = Path.Combine(OutputDirectory, subdirectory);

                if (!Directory.Exists(subdirectoryPath))
                {
                    Directory.CreateDirectory(subdirectoryPath);

                    Logger?.LogInformation("'{0}' directory has been created", subdirectoryPath);
                }
            }

            var finalPath = String.IsNullOrEmpty(fileName) ? Path.Combine(OutputDirectory, subdirectory, FullFileName) : Path.Combine(OutputDirectory, subdirectory, fileName);

            TextFileHelper.CreateFile(finalPath, Code);

            Logger?.LogInformation("'{0}' file has been created", finalPath);
        }
    }
}
