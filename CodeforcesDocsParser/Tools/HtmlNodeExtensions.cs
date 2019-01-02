using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace CodeforcesDocsParser.Tools
{
    public static class HtmlNodeExtensions
    {
        /// <summary>
        ///     Remove useless element from child list
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> TagOnly(this HtmlNodeCollection collection)
        {
            return collection.Where(node => node.Name != "#text");
        }
    }
}