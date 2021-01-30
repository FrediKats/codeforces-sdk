using System;
using System.Collections.Generic;
using CodeforcesDocsParser.TypeGenerator;
using CodeforcesDocsParser.Types;

namespace CodeforcesDocsParser
{
    static class Program
    {
        private static void Main()
        {
            List<ClassDescriptor> descriptors = ModelsParser.GroupByClass();
            foreach (ClassDescriptor descriptor in descriptors)
            {
                string classInformation = $"\n{descriptor.ClassName} ({descriptor.Summary})\n";
                classInformation += string.Join("\n", descriptor.Properties);
                Console.WriteLine(classInformation);
            }

            //SharpCodeGenerator generator = new SharpCodeGenerator("CodeforcesApiWrapper.Types", descriptors, EnumStorage.Enums);
        }
    }
}
