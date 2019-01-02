using System.Collections.Generic;
using System.Linq;
using CodeforcesDocsParser.TypeGenerator;

namespace CodeforcesDocsParser.Types
{
    public class EnumDescriptor
    {
        public EnumDescriptor(string className, string propertyName, string description)
        {
            className = className.LowerToUpperCamelCase();
            propertyName = propertyName.LowerToUpperCamelCase();

            Name = $"{className}{propertyName}Enum";

            //TODO: One more dirty hack
            if (propertyName == "Testset")
            {
                Values = description
                    .Remove(0, 6)
                    .Split(", ")
                    .Select(v => v.Trim())
                    .Select(v => v.SnakeToCamelCase())
                    .ToList();
                Values[Values.Count - 1] = Values[Values.Count - 1].Split('.').First();
                Values.Remove("...");
                return;
            }

            Values = description
                .Remove(0, 6)
                .Split('.')
                .First()
                .Split(", ")
                .Select(v => v.Trim())
                .Select(v => v.SnakeToCamelCase())
                .ToList();
            Summary = description.Split('.').Skip(1).Aggregate((a, b) => $"{a}. {b}");
        }

        public string Name { get; set; }
        public List<string> Values { get; set; }
        public string Summary { get; set; }
    }
}