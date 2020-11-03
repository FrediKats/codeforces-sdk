using System.Collections.Generic;
using System.Linq;
using Refit;

namespace CodeforcesApiWrapper.NonStandardTypes
{
    public class TagsArgument
    {
        public TagsArgument(IEnumerable<string> tags)
        {
            Tags = tags.Aggregate((a, b) => $"{a};{b}");
        }

        [AliasAs("tags")]
        public string Tags { get; set; }
    }
}