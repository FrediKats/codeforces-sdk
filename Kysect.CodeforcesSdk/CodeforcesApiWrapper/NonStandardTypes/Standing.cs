using System.Collections.Generic;
using CodeforcesApiWrapper.Types;

namespace CodeforcesApiWrapper.NonStandardTypes
{
    public class Standing
    {
        public Contest Contest { get; set; }
        public List<Problem> Problems { get; set; }
        public List<RanklistRow> Rows { get; set; }
    }
}