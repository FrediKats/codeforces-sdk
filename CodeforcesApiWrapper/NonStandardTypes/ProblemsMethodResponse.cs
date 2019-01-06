using System.Collections.Generic;
using CodeforcesApiWrapper.Types;

namespace CodeforcesApiWrapper.NonStandardTypes
{
    public class ProblemsMethodResponse
    {
        public List<Problem> Problems { get; set; }
        public List<ProblemStatistics> ProblemStatistics { get; set; }
    }
}