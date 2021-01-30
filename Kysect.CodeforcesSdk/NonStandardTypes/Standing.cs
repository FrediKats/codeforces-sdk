using System.Collections.Generic;
using Kysect.CodeforcesSdk.Types;

namespace Kysect.CodeforcesSdk.NonStandardTypes
{
    public class Standing
    {
        public Contest Contest { get; set; }
        public List<Problem> Problems { get; set; }
        public List<RanklistRow> Rows { get; set; }
    }
}