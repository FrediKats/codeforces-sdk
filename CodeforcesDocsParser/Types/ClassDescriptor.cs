using System.Collections.Generic;

namespace CodeforcesDocsParser.Types
{
    public class ClassDescriptor
    {
        public ClassDescriptor()
        {
        }

        public ClassDescriptor(string className, string description, List<(string name, string description)> properties)
        {
            ClassName = className;
            Description = description;
            Properties = properties;
        }

        public string ClassName { get; set; }
        public string Description { get; set; }
        public List<(string name, string description)> Properties { get; set; }
    }
}
