namespace Kysect.CodeforcesSdk.Types
{
	/// <summary>
	/// 	Represents a contest on Codeforces.
	/// </summary>
	public class Contest
	{
		public int Id { get; set; }
	
		/// <summary>
		/// 	Localized.
		/// </summary>
		public string Name { get; set; }
	
		/// <summary>
		/// 	Enum: CF, IOI, ICPC. Scoring system used for the contest.
		/// </summary>
		public ContestTypeEnum Type { get; set; }
	
		/// <summary>
		/// 	Enum: BEFORE, CODING, PENDING_SYSTEM_TEST, SYSTEM_TEST, FINISHED.
		/// </summary>
		public ContestPhaseEnum Phase { get; set; }
	
		/// <summary>
		/// 	If true, then the ranklist for the contest is frozen and shows only submissions, created before freeze.
		/// </summary>
		public bool Frozen { get; set; }
	
		/// <summary>
		/// 	Duration of the contest in seconds.
		/// </summary>
		public int DurationSeconds { get; set; }
	
		/// <summary>
		/// 	Can be absent. Contest start time in unix format.
		/// </summary>
		public int StartTimeSeconds { get; set; }
	
		/// <summary>
		/// 	Can be absent. Number of seconds, passed after the start of the contest. Can be negative.
		/// </summary>
		public int RelativeTimeSeconds { get; set; }
	
		/// <summary>
		/// 	Can be absent. Handle of the user, how created the contest.
		/// </summary>
		public string PreparedBy { get; set; }
	
		/// <summary>
		/// 	Can be absent. URL for contest-related website.
		/// </summary>
		public string WebsiteUrl { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string Description { get; set; }
	
		/// <summary>
		/// 	Can be absent. From 1 to 5. Larger number means more difficult problems.
		/// </summary>
		public int Difficulty { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent. Human-readable type of the contest from the following categories: Official ACM-ICPC Contest, Official School Contest, Opencup Contest, School/University/City/Region Championship, Training Camp Contest, Official International Personal Contest, Training Contest.
		/// </summary>
		public string Kind { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent. Name of the ICPC Region for official ACM-ICPC contests.
		/// </summary>
		public string IcpcRegion { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string Country { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string City { get; set; }
	
		/// <summary>
		/// 	Can be absent.
		/// </summary>
		public string Season { get; set; }
	
	}
}