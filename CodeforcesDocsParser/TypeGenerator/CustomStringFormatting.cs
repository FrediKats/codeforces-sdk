using System.Linq;

namespace CodeforcesDocsParser.TypeGenerator
{
    public static class StringExtensions
    {
        public static string LowerToUpperCamelCase(this string name)
        {
            name = name.Trim();
            char firstLetter = char.ToUpper(name[0]);
            return (firstLetter + name.Remove(0, 1)).Trim();
        }

        public static string SnakeToCamelCase(this string name)
        {
            return name
                .ToLower()
                .Split("_")
                .Select(LowerToUpperCamelCase)
                .Aggregate((a , b) => a + b);
        }

        public static (string type, string description) SplitDescription(this string s)
        {
            string[] data = s.Split('.');
            return (data[0], s.Remove(0, data[0].Length).TrimStart('.', ' '));
        }

        public static string NthWord(this string s, int position)
        {
            string[] words = s.Split(' ');
            return words.Length < position ? null : words[position - 1];
        }
    }
}