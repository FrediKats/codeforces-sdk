using System.Collections.Generic;
using CodeforcesDocsParser.Types;

namespace CodeforcesDocsParser.Tools
{
    public static class EnumStorage
    {
        public static readonly List<EnumDescriptor> Enums = new List<EnumDescriptor>();

        public static EnumDescriptor AddNew(string className, string propertyName, string description)
        {
            var newEnum = new EnumDescriptor(className, propertyName, description);
            Enums.Add(newEnum);
            return newEnum;
        }
    }
}