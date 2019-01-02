using CodeforcesDocsParser.Tools;

namespace CodeforcesDocsParser.Types
{
    public class PropertyDescriptor
    {
        public PropertyDescriptor(string name, string description)
        {
            Name = name.ToCamelCase();
            string[] stringParts = description.Split(".");
            Type = stringParts[0];
            if (stringParts.Length > 1)
            {
                Summary = stringParts[1];
            }
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