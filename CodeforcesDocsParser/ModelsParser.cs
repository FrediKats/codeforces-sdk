using System.Collections.Generic;
using System.Linq;
using CodeforcesDocsParser.Tools;
using CodeforcesDocsParser.Types;
using HtmlAgilityPack;

namespace CodeforcesDocsParser
{
    public static class ModelsParser
    {
        private const string Url = "https://codeforces.com/api/help/objects";

        private static HtmlNode LoadContentNode()
        {
            var client = new HtmlWeb();
            HtmlDocument doc = client.Load(Url);

            HtmlNode contentNode = doc
                .DocumentNode
                .Descendants()
                .First(node => node.Attributes?["class"]?.Value == "ttypography");

            return contentNode;
        }

        private static List<PropertyDescriptor> GetDataFromTable(HtmlNode table)
        {
            HtmlNode body = table.Element("tbody");
            var result = new List<PropertyDescriptor>();
            foreach (HtmlNode child in body.ChildNodes.TagOnly())
            {
                HtmlNode[] elements = child.ChildNodes.TagOnly().ToArray();
                string propertyName = elements[0].InnerText;
                string propertyDescription = elements[1].InnerText;
                var property = new PropertyDescriptor(propertyName, propertyDescription);
                result.Add(property);
            }

            return result;
        }

        public static List<ClassDescriptor> GroupByClass()
        {
            HtmlNode contentNode = LoadContentNode();

            // Remove <h1>Return objects</h1>
            HtmlNode[] elements = contentNode.ChildNodes.TagOnly().Skip(1).ToArray();
            var classes = new List<ClassDescriptor>();

            for (int i = 0; i < elements.Length; i += 3)
            {
                string className = elements[i].InnerText;
                string description = elements[i + 1].InnerText;
                List<PropertyDescriptor> properties = GetDataFromTable(elements[i + 2]);

                classes.Add(new ClassDescriptor(className, description, properties));
            }

            return classes;
        }
    }
}