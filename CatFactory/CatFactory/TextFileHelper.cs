using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CatFactory
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

        public static void Append(string path, string data)
            => WriteFile(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, false);

        public static void AppendLine(string path, string data)
            => WriteFile(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, true);

        public static void Clear(string path)
            => WriteFile(path, string.Empty, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        public static async Task WriteFileAsync(string path, string data, FileMode mode, FileAccess access, Encoding encoding, bool addLine)
        {
            using (var file = new FileStream(path, mode, access))
            {
                using (var stream = new StreamWriter(file, encoding))
                {
                    if (addLine)
                        await stream.WriteLineAsync(data);
                    else
                        await stream.WriteAsync(data);
                }
            }
        }

        public static async Task CreateFileAsync(string path, string data)
            => await WriteFileAsync(path, data, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        public static async Task AppendAsync(string path, string data)
            => await WriteFileAsync(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, false);

        public static async Task AppendLineAsync(string path, string data)
            => await WriteFileAsync(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, true);

        public static async Task ClearAsync(string path)
            => await WriteFileAsync(path, string.Empty, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);
    }
}
