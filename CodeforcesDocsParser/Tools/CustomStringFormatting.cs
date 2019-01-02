namespace CodeforcesDocsParser.Tools
{
    public static class CustomStringFormatting
    {
        public static string ToCamelCase(this string name)
        {
            char firstLetter = char.ToUpper(name[0]);
            return (firstLetter + name.Remove(0, 1)).Trim();
        }
    }
}