namespace Kysect.CodeforcesSdk.Types
{
	/// <summary>
	/// 	Represents a submissions results of a party for a problem.
	/// </summary>
	public class ProblemResult
	{
		public double Points { get; set; }
	
		/// <summary>
		/// 	Penalty (in ICPC meaning) of the party for this problem.
		/// </summary>
		public int Penalty { get; set; }
	
		/// <summary>
		/// 	Number of incorrect submissions.
		/// </summary>
		public int RejectedAttemptCount { get; set; }
	
		/// <summary>
		/// 	Enum: PRELIMINARY, FINAL. If type is PRELIMINARY then points can decrease (if, for example, solution will fail during system test). Otherwise, party can only increase points for this problem by submitting better solutions.
		/// </summary>
		public ProblemResultTypeEnum Type { get; set; }
	
		/// <summary>
		/// 	Number of seconds after the start of the contest before the submission, that brought maximal amount of points for this problem.
		/// </summary>
		public int BestSubmissionTimeSeconds { get; set; }
	
	}
}