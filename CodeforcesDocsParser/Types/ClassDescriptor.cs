using System.Collections.Generic;
using System.Linq;

namespace CodeforcesDocsParser.Types
{
    public class ClassDescriptor
    {
        public ClassDescriptor(string className, string description, List<PropertyDescriptor> properties)
        {
            ClassName = className;
            Description = description;
            Properties = properties;
        }

        public string ClassName { get; set; }
        public string Description { get; set; }
        public List<PropertyDescriptor> Properties { get; set; }
    }
}