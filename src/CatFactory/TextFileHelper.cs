using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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

        public static void Append(String path, String data)
            => WriteFile(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, false);

        public static void AppendLine(String path, String data)
            => WriteFile(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, true);

        public static void Clear(String path)
            => WriteFile(path, String.Empty, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        public static async Task WriteFileAsync(String path, String data, FileMode mode, FileAccess access, Encoding encoding, Boolean addLine)
        {
            using (var file = new FileStream(path, mode, access))
            {
                using (var stream = new StreamWriter(file, encoding))
                {
                    if (addLine)
                    {
                        await stream.WriteLineAsync(data);
                    }
                    else
                    {
                        await stream.WriteAsync(data);
                    }
                }
            }
        }

        public static async Task CreateFileAsync(String path, String data)
            => await WriteFileAsync(path, data, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        public static async Task AppendAsync(String path, String data)
            => await WriteFileAsync(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, false);

        public static async Task AppendLineAsync(String path, String data)
            => await WriteFileAsync(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, true);

        public static async Task ClearAsync(String path)
            => await WriteFileAsync(path, String.Empty, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);
    }
}
