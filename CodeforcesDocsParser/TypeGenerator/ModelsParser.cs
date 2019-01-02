using System.Collections.Generic;
using System.Linq;
using CodeforcesDocsParser.HtmlDocsParser;
using CodeforcesDocsParser.Types;

namespace CodeforcesDocsParser.TypeGenerator
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

            (string type, string summary) = second.SplitDescription();

            if (type.NthWord(1) == "List")
            {
                return new PropertyDescriptor(first, $"{second.NthWord(3)}[]", summary);
            }

            if (type.NthWord(1) == "Floating")
            {
                return new PropertyDescriptor(first, "Double", summary);
            }

            if (type == "String list")
            {
                return new PropertyDescriptor(first, "String[]", summary);
            }

            if (type.NthWord(2) == "object")
            {
                return new PropertyDescriptor(first, type.NthWord(1), summary);
            }

            //TODO: Dirty hacks. Request Mike for fix
            if (first == "judgeProtocol")
            {
                return new PropertyDescriptor(first, "Object", summary);
            }

            return new PropertyDescriptor(first, type, summary);
        }
    }
}