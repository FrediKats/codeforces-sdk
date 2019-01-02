using System.Collections.Generic;

namespace CodeforcesDocsParser.Types
{
    public class ClassDescriptor
    {
        public ClassDescriptor(string className, string summary, List<PropertyDescriptor> properties)
        {
            ClassName = className;
            Summary = summary;
            Properties = properties;
        }

        public string ClassName { get; set; }
        public string Summary { get; set; }
        public List<PropertyDescriptor> Properties { get; set; }
    }
}