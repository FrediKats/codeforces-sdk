using System.Collections.Generic;

namespace CodeforcesDocsParser.HtmlDocsParser
{
    public class DocsObject
    {
        public DocsObject(string header, string description, List<(string, string)> tableRows)
        {
            Header = header;
            Description = description;
            TableRows = tableRows;
        }

        public string Header { get; set; }
        public string Description { get; set; }
        public List<(string, string)> TableRows { get; set; }
    }
}