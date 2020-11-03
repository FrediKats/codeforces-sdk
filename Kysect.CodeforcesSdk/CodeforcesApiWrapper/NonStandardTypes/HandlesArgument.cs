using System.Collections.Generic;
using System.Linq;
using Refit;

namespace CodeforcesApiWrapper.NonStandardTypes
{
    public class HandlesArgument
    {
        public HandlesArgument(IEnumerable<string> handlers)
        {
            Handles = handlers.Aggregate((a, b) => $"{a};{b}");
        }

        [AliasAs("handles")]
        public string Handles { get; set; }
    }
}