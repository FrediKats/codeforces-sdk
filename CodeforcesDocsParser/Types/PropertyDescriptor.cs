using CodeforcesDocsParser.Tools;

namespace CodeforcesDocsParser.Types
{
    public class PropertyDescriptor
    {
        public PropertyDescriptor(string name, string type, string summary)
        {
            Name = name;
            Type = type;
            Summary = summary;
        }

        public static PropertyDescriptor FromRow(string name, string description)
        {
            name = name.LowerToUpperCamelCase();
            string[] stringParts = description.Split(".");

            string type = stringParts[0];
            string summary = null;
            if (stringParts.Length > 1)
            {
                summary = stringParts[1];
            }
            return new PropertyDescriptor(name, type, summary);
        }


        public string Name { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }

        public override string ToString()
        {
            return $"{Type} {Name} //{Summary}";
        }
    }
}