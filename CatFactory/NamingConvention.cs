using System.Collections.Generic;
using System.Text;

namespace CatFactory
{
    /// <summary>
    /// Provides helper methods for naming conventions
    /// </summary>
    public static class NamingConvention
    {
        private static bool IsLower(string source)
            => source.ToLower() == source;

        private static bool IsUpper(string source)
            => source.ToUpper() == source;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetCamelCase(string source)
        {
            if (source.Length == 0)
                return string.Empty;

            if (source.Contains(" "))
            {
                var pieces = source.Split(' ');

                var name = new StringBuilder();

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                        continue;

                    name.Append(i == 0 ? item[0].ToString().ToLower() : item[0].ToString().ToUpper());
                    name.Append(item.Substring(1));
                }

                return name.ToString();
            }
            else if (source.Contains("_"))
            {
                var pieces = source.Split('_');

                var name = new StringBuilder();

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                        continue;

                    name.Append(i == 0 ? item[0].ToString().ToLower() : item[0].ToString().ToUpper());
                    name.Append(item.Substring(1));
                }

                return name.ToString();
            }
            else
            {
                if (source.Length == 1 || IsUpper(source))
                    return source.ToLower();

                return string.Format("{0}{1}", source[0].ToString().ToLower(), source.Substring(1))
                    .Replace("_", string.Empty).Replace(".", string.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetPascalCase(string source)
        {
            if (source.Length == 0)
                return string.Empty;

            source = source.Replace("  ", " ").Trim();

            var name = new StringBuilder();

            if (source.Contains("_"))
            {
                var pieces = source.Split('_');

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                        continue;

                    name.Append(item[0].ToString().ToUpper());
                    name.Append(IsUpper(item) ? item.Substring(1).ToLower() : item.Substring(1));
                }
            }
            else if (source.Contains("."))
            {
                var pieces = source.Split('.');

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                        continue;

                    name.Append(item[0].ToString().ToUpper());
                    name.Append(IsUpper(item) ? item.Substring(1).ToLower() : item.Substring(1));
                }
            }
            else if (source.Contains(" "))
            {
                var pieces = source.Split(' ');

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                        continue;

                    name.Append(item[0].ToString().ToUpper());
                    name.Append(item.Substring(1).ToLower());
                }
            }
            else
            {
                if (source.Length == 1)
                {
                    name.Append(source.ToUpper());
                }
                else
                {
                    name.Append(source[0].ToString().ToUpper());
                    name.Append(IsUpper(source) ? source.Substring(1).ToLower() : source.Substring(1));
                }
            }

            return name.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetSnakeCase(string source)
        {
            if (source.Length == 0)
                return string.Empty;

            if (source.Contains("_"))
                return source;

            source = source.Replace("  ", " ").Trim();

            var name = new List<string>();

            if (source.Contains("."))
            {
                var pieces = source.Split('.');

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                        continue;

                    name.Add(item);
                }
            }
            else if (source.Contains(" "))
            {
                var pieces = source.Split(' ');

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                        continue;

                    name.Add(item);
                }
            }
            else
            {
                name.Add(source);
            }

            return string.Join("_", name);
        }
    }
}