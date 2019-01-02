namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	Represents a statistic data about a problem.
	/// </summary>
	public class ProblemStatistics
	{
		/// <summary>
		/// 	Can be absent. Id of the contest, containing the problem.
		/// </summary>
		public int ContestId { get; set; }
		/// <summary>
		/// 	Usually a letter of a letter, followed by a digit, that represent a problem index in a contest.
		/// </summary>
		public string Index { get; set; }
		/// <summary>
		/// 	Number of users, who solved the problem.
		/// </summary>
		public int SolvedCount { get; set; }
	}
}