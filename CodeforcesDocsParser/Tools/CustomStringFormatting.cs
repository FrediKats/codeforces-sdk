using System.Linq;

namespace CodeforcesDocsParser.Tools
{
    public static class CustomStringFormatting
    {
        public static string LowerToUpperCamelCase(this string name)
        {
            name = name.Trim();
            char firstLetter = char.ToUpper(name[0]);
            return (firstLetter + name.Remove(0, 1)).Trim();
        }

        public static string SnakeToCammelCase(this string name)
        {
            return name
                .ToLower()
                .Split("_")
                .Select(LowerToUpperCamelCase)
                .Aggregate((a , b) => a + b);
        }
    }
}