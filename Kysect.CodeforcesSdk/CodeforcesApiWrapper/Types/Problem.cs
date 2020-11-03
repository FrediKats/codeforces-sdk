using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	Represents a problem.
	/// </summary>
	public class Problem
	{
		/// <summary>
		/// 	Can be absent. Id of the contest, containing the problem.
		/// </summary>
		public int ContestId { get; set; }
	
		/// <summary>
		/// 	Can be absent. Short name of the problemset the problem belongs to.
		/// </summary>
		public string ProblemsetName { get; set; }
	
		/// <summary>
		/// 	Usually a letter of a letter, followed by a digit, that represent a problem index in a contest.
		/// </summary>
		public string Index { get; set; }
	
		/// <summary>
		/// 	Localized.
		/// </summary>
		public string Name { get; set; }
	
		/// <summary>
		/// 	Enum: PROGRAMMING, QUESTION.
		/// </summary>
		public ProblemTypeEnum Type { get; set; }
	
		/// <summary>
		/// 	Can be absent. Maximum ammount of points for the problem.
		/// </summary>
		public double Points { get; set; }
	
		/// <summary>
		/// 	Problem tags.
		/// </summary>
		public string[] Tags { get; set; }
	
	}
}