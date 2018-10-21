using System.IO;
using System.Text;

namespace CatFactory.Tests.Helpers
{
    public static class TextFileHelper
    {
        public static void WriteFile(string path, string data, FileMode mode, FileAccess access, Encoding encoding, bool addLine)
        {
            using (var file = new FileStream(path, mode, access))
            {
                using (var stream = new StreamWriter(file, encoding))
                {
                    if (addLine)
                        stream.WriteLine(data);
                    else
                        stream.Write(data);
                }
            }
        }

        public static void CreateFile(string path, string data)
            => WriteFile(path, data, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);
    }
}
