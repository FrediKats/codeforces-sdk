using System.Collections.Generic;
using CodeforcesApiWrapper.Types;

namespace CodeforcesApiWrapper.NonStandartTypes
{
    public class Standing
    {
        public Contest Contest { get; set; }
        public List<Problem> Problems { get; set; }
        public List<RanklistRow> Rows { get; set; }
    }
}