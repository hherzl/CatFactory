using System;
using System.IO;
using System.Text;

namespace CatFactory
{
    public static class TextFileHelper
    {
        public static void WriteFile(String path, String data, FileMode mode, FileAccess access, Encoding encoding, Boolean addLine)
        {
            using (var file = new FileStream(path, mode, access))
            {
                using (var stream = new StreamWriter(file, encoding))
                {
                    if (addLine)
                    {
                        stream.WriteLine(data);
                    }
                    else
                    {
                        stream.Write(data);
                    }
                }
            }
        }

        public static void CreateFile(String path, String data)
            => WriteFile(path, data, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        public static void AppendLine(String path, String data)
            => WriteFile(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, true);

        public static void Clear(String path)
            => WriteFile(path, String.Empty, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);
    }
}
