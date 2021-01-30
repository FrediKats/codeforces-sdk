using System.Collections.Generic;
using Kysect.CodeforcesSdk.Types;

namespace Kysect.CodeforcesSdk.NonStandardTypes
{
    public class ProblemsMethodResponse
    {
        public List<Problem> Problems { get; set; }
        public List<ProblemStatistics> ProblemStatistics { get; set; }
    }
}