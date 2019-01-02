using System.Collections.Generic;
using System.Linq;
using CodeforcesDocsParser.Tools;
using HtmlAgilityPack;

namespace CodeforcesDocsParser.HtmlDocsParser
{
    public class PageParser
    {
        private const string Url = "https://codeforces.com/api/help/objects";

        public static List<DocsObject> ParsePage()
        {
            HtmlNode contentNode = LoadContentNode();

            // Remove <h1>Return objects</h1>
            HtmlNode[] elements = contentNode.ChildNodes.TagOnly().Skip(1).ToArray();
            var objects = new List<DocsObject>();

            for (var i = 0; i < elements.Length; i += 3)
            {
                string header = elements[i].InnerText;
                string description = elements[i + 1].InnerText;
                List<(string, string)> dataFromTable = GetDataFromTable(elements[i + 2]);

                objects.Add(new DocsObject(header, description, dataFromTable));
            }

            return objects;
        }

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

        private static List<(string, string)> GetDataFromTable(HtmlNode table)
        {
            HtmlNode body = table.Element("tbody");
            var row = new List<(string, string)>();

            foreach (HtmlNode child in body.ChildNodes.TagOnly())
            {
                HtmlNode[] elements = child.ChildNodes.TagOnly().ToArray();
                string firstColumn = elements[0].InnerText;
                string secondColumn = elements[1].InnerText;

                row.Add((firstColumn, secondColumn));
            }

            return row;
        }
    }
}