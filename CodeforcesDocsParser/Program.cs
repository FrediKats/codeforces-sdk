using System;
using System.Collections.Generic;
using System.Linq;
using CodeforcesDocsParser.Types;

namespace CodeforcesDocsParser
{
    static class Program
    {
        private static void Main(string[] args)
        {
            List<ClassDescriptor> descriptors = ModelsParser.GroupByClass();
            foreach (ClassDescriptor descriptor in descriptors)
            {
                string classInformation = $"\n{descriptor.ClassName} ({descriptor.Description})\n";
                classInformation += string.Join("\n", descriptor.Properties.Select(p => $"{p.name}: {p.description}"));
                Console.WriteLine(classInformation);
            }
        }
    }
}
