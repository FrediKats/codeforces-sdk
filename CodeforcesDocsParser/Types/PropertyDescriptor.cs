using CodeforcesDocsParser.TypeGenerator;

namespace CodeforcesDocsParser.Types
{
    public class PropertyDescriptor
    {
        public PropertyDescriptor(string name, string type, string summary)
        {
            Name = name.LowerToUpperCamelCase();
            Type = type;
            Summary = summary;
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