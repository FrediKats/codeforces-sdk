using System.Collections.Generic;
using System.Linq;
using CodeforcesDocsParser.HtmlDocsParser;
using CodeforcesDocsParser.Tools;
using CodeforcesDocsParser.Types;
using HtmlAgilityPack;

namespace CodeforcesDocsParser
{
    public static class ModelsParser
    {
        public static List<ClassDescriptor> GroupByClass()
        {
            List<DocsObject> docsObjects = PageParser.ParsePage();
            var classes = new List<ClassDescriptor>();

            foreach (DocsObject docsObject in docsObjects)
            {
                List<PropertyDescriptor> properties = docsObject
                    .TableRows
                    .Select(r => GetDescriptor(docsObject, r.Item1, r.Item2))
                    .ToList();

                classes.Add(new ClassDescriptor(docsObject.Header, docsObject.Description, properties));
            }
            return classes;
        }

        private static PropertyDescriptor GetDescriptor(DocsObject docsObject, string first, string second)
        {
            if (second.Contains("Enum:"))
            {
                EnumDescriptor enumType = EnumStorage.AddNew(docsObject.Header, first, second);
                return new PropertyDescriptor(first, enumType.Name, second);
            }

            return PropertyDescriptor.FromRow(first, second);
        }
    }
}