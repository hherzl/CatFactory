using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CatFactory
{
    /// <summary>
    /// 
    /// </summary>
    [Obsolete("Use static methods in System.IO.File class")]
    public static class TextFileHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="encoding"></param>
        /// <param name="addLine"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        public static void CreateFile(string path, string data)
            => WriteFile(path, data, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        public static void Append(string path, string data)
            => WriteFile(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        public static void AppendLine(string path, string data)
            => WriteFile(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, true);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static void Clear(string path)
            => WriteFile(path, string.Empty, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="encoding"></param>
        /// <param name="addLine"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task CreateFileAsync(string path, string data)
            => await WriteFileAsync(path, data, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task AppendAsync(string path, string data)
            => await WriteFileAsync(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task AppendLineAsync(string path, string data)
            => await WriteFileAsync(path, data, FileMode.Append, FileAccess.Write, Encoding.Unicode, true);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static async Task ClearAsync(string path)
            => await WriteFileAsync(path, string.Empty, FileMode.Create, FileAccess.Write, Encoding.Unicode, false);
    }
}
