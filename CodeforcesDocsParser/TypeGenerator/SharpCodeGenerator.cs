using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeforcesDocsParser.Types;

namespace CodeforcesDocsParser.TypeGenerator
{
    public class SharpCodeGenerator
    {
        private const string DirectoryName = "Types";

        public SharpCodeGenerator(string typesNamespace, List<ClassDescriptor> classes, List<EnumDescriptor> enums)
        {
            if (Directory.Exists(DirectoryName))
            {
                string[] files = Directory.GetFiles(DirectoryName);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            else
            {
                Directory.CreateDirectory(DirectoryName);
            }

            foreach (ClassDescriptor classDescriptor in classes)
            {
                string content = PutInNamespace(typesNamespace, ClassContentGenerator(classDescriptor));
                File.WriteAllText($"{DirectoryName}/{classDescriptor.ClassName}.cs", content);
            }

            foreach (EnumDescriptor enumDescriptor in enums)
            {
                string content = PutInNamespace(typesNamespace, EnumContentGenerator(enumDescriptor));
                File.WriteAllText($"{DirectoryName}/{enumDescriptor.Name}.cs", content);
            }
        }

        private static string PutInNamespace(string typesNamespace, List<string> content)
        {
            return $"namespace {typesNamespace}\n"
                   + "{\n"
                   + string.Join("\n", content.Select(r => $"\t{r}"))
                   + "\n}";
        }

        private static List<string> ClassContentGenerator(ClassDescriptor classDescriptor)
        {
            var rows = new List<string>();

            rows.Add($"public class {classDescriptor.ClassName}");
            rows.Add("{");
            foreach (PropertyDescriptor property in classDescriptor.Properties)
            {
                string sharpType = ToBaseType(property.Type);
                rows.Add($"\tpublic {sharpType} {property.Name}" + " { get; set; }");
            }

            rows.Add("}");

            return rows;
        }

        private static List<string> EnumContentGenerator(EnumDescriptor enumDescriptor)
        {
            var rows = new List<string>();

            rows.Add($"public enum {enumDescriptor.Name}");
            rows.Add("{");
            foreach (string value in enumDescriptor.Values)
            {
                rows.Add($"\t{value},");
            }

            rows.Add("}");

            return rows;
        }

        private static string ToBaseType(string type)
        {
            var array = "";
            if (type.Contains("[]"))
            {
                array = "[]";
            }

            switch (type.Replace("[]", ""))
            {
                case "Integer":
                    return "int" + array;
                case "String":
                    return "string" + array;
                case "Double":
                    return "double" + array;
                case "Boolean":
                    return "bool" + array;
                case "Object":
                    return "object" + array;
                default:
                    return type;
            }
        }
    }
}