using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CatFactory
{
    /// <summary>
    /// Provides helper methods for naming conventions
    /// </summary>
    /// <remarks>Thanks to ewmccarty <!-- https://github.com/ewmccarty --> by adding XML comments for GetCamelCase, GetPascalCase and GetSnakeCase methods.</remarks>
    public static class NamingConvention
    {
        private static bool IsLower(string source)
            => source.ToLower() == source;

        private static bool IsUpper(string source)
            => source.ToUpper() == source;

        private static bool HasUpper(string source)
            => source.Any(char.IsUpper);

        private static bool HasLower(string source)
            => source.Any(char.IsLower);

        /// <summary>
        /// Gets a camelCase style string. Except for first word, First Character of each word is capitalized, , all whitespace, symbols and punctuation are removed.
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>A <see cref="string"/> that represents camelString for source string</returns>
        /// <remarks>
        /// <!-- https://en.wikipedia.org/wiki/Camel_case -->
        /// Camel case (stylized as camelCase; also known as camel caps or more formally as medial capitals) is the
        /// practice of writing phrases such that each word or abbreviation in the middle of the phrase begins with a
        /// capital letter, with no intervening spaces or punctuation. Common examples include "iPhone" and "eBay".
        /// It is also sometimes used in online usernames such as "johnSmith", and to make multi-word domain names more
        /// legible, for example in advertisements.
        ///
        /// Camel case is often used for variable names in computer programming. Some programming styles prefer camel
        /// case with the first letter capitalised, others not.[1][2][3] For clarity, this article calls the two
        /// alternatives upper camel case (initial uppercase letter, also known as Pascal case) and lower camel case
        /// (initial lowercase letter). Some people and organizations, notably Microsoft,[2] use the term camel case
        /// only for lower camel case. Pascal case means only upper camel case.
        ///
        /// Camel case is distinct from Title Case, which capitalises all words but retains the spaces between them,
        /// and from Tall Man lettering, which uses capitals to emphasize the differences between similar-looking words
        /// such as "predniSONE" and "predniSOLONE". Camel case is also distinct from snake case, which uses underscores
        /// interspersed with lowercase letters (sometimes with the first letter capitalized). The combination of
        /// "upper camel case" and "snake case" is known as "Darwin case". Darwin case uses underscores between words
        /// with initial uppercase letters, as in "Sample_Type". It has no known conventional use in computer
        /// programming but is named after Charles Darwin because of the way it has "evolved" from more traditional
        /// conventions.[citation needed]
        /// </remarks>
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
                if ((source.Length == 1) || IsUpper(source))
                    return source.ToLower();

                var lower = source[0].ToString().ToLower();
                var substring = source.Substring(1);
                return $"{lower}{substring}".Replace("_", string.Empty).Replace(".", string.Empty);
            }
        }

        /// <summary>
        /// Gets a CamelCase style string
        ///
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>A <see cref="string"/> that represents PascalString for source string</returns>
        /// <remarks>
        /// <!-- https://en.wikipedia.org/wiki/Camel_case -->
        /// Camel case (stylized as camelCase; also known as camel caps or more formally as medial capitals) is the
        /// practice of writing phrases such that each word or abbreviation in the middle of the phrase begins with a
        /// capital letter, with no intervening spaces or punctuation. Common examples include "iPhone" and "eBay".
        /// It is also sometimes used in online usernames such as "johnSmith", and to make multi-word domain names more
        /// legible, for example in advertisements.
        ///
        /// Camel case is often used for variable names in computer programming. Some programming styles prefer camel
        /// case with the first letter capitalised, others not.[1][2][3] For clarity, this article calls the two
        /// alternatives upper camel case (initial uppercase letter, also known as Pascal case) and lower camel case
        /// (initial lowercase letter). Some people and organizations, notably Microsoft,[2] use the term camel case
        /// only for lower camel case. Pascal case means only upper camel case.
        ///
        /// Camel case is distinct from Title Case, which capitalises all words but retains the spaces between them,
        /// and from Tall Man lettering, which uses capitals to emphasize the differences between similar-looking words
        /// such as "predniSONE" and "predniSOLONE". Camel case is also distinct from snake case, which uses underscores
        /// interspersed with lowercase letters (sometimes with the first letter capitalized). The combination of
        /// "upper camel case" and "snake case" is known as "Darwin case". Darwin case uses underscores between words
        /// with initial uppercase letters, as in "Sample_Type". It has no known conventional use in computer
        /// programming but is named after Charles Darwin because of the way it has "evolved" from more traditional
        /// conventions.[citation needed]
        /// </remarks>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetPascalCase(string source)
        {
            if ((string.IsNullOrEmpty(source?.Trim())) || (source.Length == 0))
                return string.Empty;

            source = source.Replace("  ", " ").Trim();

            var name = new StringBuilder();

            if (source.Contains("_"))
            {
                var pieces = source.Split('_');

                foreach (var item in pieces)
                {
                    if (item.Length == 0)
                        continue;

                    name.Append(item[0].ToString().ToUpper());
                    name.Append(IsUpper(item) ? item.Substring(1).ToLower() : item.Substring(1));
                }
            }
            else if (source.Contains("."))
            {
                var pieces = source.Split('.');

                foreach (var item in pieces)
                {
                    if (item.Length == 0)
                        continue;

                    name.Append(item[0].ToString().ToUpper());
                    name.Append(IsUpper(item) ? item.Substring(1).ToLower() : item.Substring(1));
                }
            }
            else if (source.Contains(" "))
            {
                var pieces = source.Split(' ');

                foreach (var item in pieces)
                {
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
        /// Gets a Snake_Case style string. Words are separated by underscore
        ///
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>A <see cref="string"/> that represents Snake_Case for source string</returns>
        /// <remarks>
        /// <!-- https://en.wikipedia.org/wiki/Snake_case -->
        /// Snake case (or snake_case) is the practice of writing compound words or phrases in which the elements are
        /// separated with one underscore character (_) and no spaces, with each element's initial letter usually
        /// lowercased within the compound and the first letter either upper- or lowercase—as in "foo_bar" and
        /// "Hello_world". It is commonly used in computer code for variable names, and function names, and sometimes
        /// computer file names.[1] At least one study found that readers can recognize snake case values more quickly
        /// than camelCase.[2]
        /// </remarks>
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

                name.AddRange(pieces.Where(item => item.Length != 0));
            }
            else if (source.Contains(" "))
            {
                var pieces = source.Split(' ');

                name.AddRange(pieces.Where(item => item.Length != 0));
            }
            else if (HasUpper(source) & !IsUpper(source))
            {
                name.AddRange(Regex.Split(source, @"(?<!^)(?=[A-Z])"));
            }
            else
            {
                name.Add(source);
            }

            return string.Join("_", name);
        }

        /// <summary>
        /// Creates  a kebab-case style string
        /// <!-- https://en.wikipedia.org/wiki/Letter_case#Special_case_styles -->
        /// "the-quick-brown-fox-jumps-over-the-lazy-dog"
        /// Similar to snake case, above, except hyphens rather than underscores are used to replace spaces.
        /// It is also known as spinal case, param case, Lisp case, and dash case (or illustratively as kebab-case)
        /// If every word is capitalized, the style is known as train case (TRAIN-CASE).[citation needed]
        /// Perl6 supports kebab case style. remark addition: It is also common for use in angular file names.
        /// which off course is relevant for a like generator like this one.
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>A <see cref="string"/> that represents kebab-case for source string</returns>
        public static string GetKebabCase(string source)
        {
            if (source.Length == 0)
                return string.Empty;

            if (source.Contains("-"))
                return source;

            source = source.Replace("  ", " ").Trim();

            var name = new List<string>();

            if (source.Contains("."))
            {
                var pieces = source.Split('.');

                name.AddRange(pieces.Where(item => item.Length != 0));
            }
            else if (source.Contains(" "))
            {
                var pieces = source.Split(' ');

                name.AddRange(pieces.Where(item => item.Length != 0));
            }
            else if (source.Contains("_"))
            {
                var pieces = source.Split('_');

                name.AddRange(pieces.Where(item => item.Length != 0));
            }
            else if (HasUpper(source) & !IsUpper(source))
            {
                name.AddRange(Regex.Split(source, @"(?<!^)(?=[A-Z])"));
            }
            else
            {
                name.Add(source);
            }

            return string.Join("-", name).ToLower();
        }
    }
}
