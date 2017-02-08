using System;
using System.Text;

namespace CatFactory.CodeFactory
{
    public static class CodeNamingConvention
    {
        private static Boolean IsFullUpper(String s)
        {
            var flag = true;

            for (var i = 0; i < s.Length; i++)
            {
                if (!Char.IsUpper(s[i]))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        public static String GetPascalCase(String s)
        {
            if (s.Length == 0)
            {
                return String.Empty;
            }

            s = s.Replace("  ", " ").Trim();

            var name = new StringBuilder();

            if (s.Contains("_"))
            {
                var pieces = s.Split('_');

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                    {
                        continue;
                    }

                    if (IsFullUpper(item))
                    {
                        name.Append(item[0].ToString().ToUpper());
                        name.Append(item.Substring(1).ToLower());
                    }
                    else
                    {
                        name.Append(item[0].ToString().ToUpper());
                        name.Append(item.Substring(1));
                    }
                }
            }
            else if (s.Contains(" "))
            {
                var pieces = s.Split(' ');

                for (var i = 0; i < pieces.Length; i++)
                {
                    var item = pieces[i];

                    if (item.Length == 0)
                    {
                        continue;
                    }

                    name.Append(item[0].ToString().ToUpper());
                    name.Append(item.Substring(1).ToLower());
                }
            }
            else
            {
                if (s.Length == 1)
                {
                    name.Append(s.ToUpper());
                }
                else
                {
                    if (IsFullUpper(s))
                    {
                        name.Append(s[0].ToString().ToUpper());
                        name.Append(s.Substring(1).ToLower());
                    }
                    else
                    {
                        name.Append(s[0].ToString().ToUpper());
                        name.Append(s.Substring(1));
                    }
                }
            }

            return name.ToString();
        }

        public static String GetCamelCase(String s)
        {
            if (s.Length == 0)
            {
                return String.Empty;
            }

            if (s.Length == 1)
            {
                return s.ToLower();
            }

            return String.Format("{0}{1}", s[0].ToString().ToLower(), s.Substring(1)).Replace("_", String.Empty);
        }
    }
}
