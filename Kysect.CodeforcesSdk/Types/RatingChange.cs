namespace Kysect.CodeforcesSdk.Types
{
	/// <summary>
	/// 	Represents a participation of user in rated contest.
	/// </summary>
	public class RatingChange
	{
		public int ContestId { get; set; }
	
		/// <summary>
		/// 	Localized.
		/// </summary>
		public string ContestName { get; set; }
	
		/// <summary>
		/// 	Codeforces user handle.
		/// </summary>
		public string Handle { get; set; }
	
		/// <summary>
		/// 	Place of the user in the contest. This field contains user rank on the moment of rating update. If afterwards rank changes (e.g. someone get disqualified), this field will not be update and will contain old rank.
		/// </summary>
		public int Rank { get; set; }
	
		/// <summary>
		/// 	Time, when rating for the contest was update, in unix-format.
		/// </summary>
		public int RatingUpdateTimeSeconds { get; set; }
	
		/// <summary>
		/// 	User rating before the contest.
		/// </summary>
		public int OldRating { get; set; }
	
		/// <summary>
		/// 	User rating after the contest.
		/// </summary>
		public int NewRating { get; set; }
	
	}
}