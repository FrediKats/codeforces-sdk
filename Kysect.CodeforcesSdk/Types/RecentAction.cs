namespace Kysect.CodeforcesSdk.Types
{
	/// <summary>
	/// 	Represents a recent action.
	/// </summary>
	public class RecentAction
	{
		/// <summary>
		/// 	Action time, in unix format.
		/// </summary>
		public int TimeSeconds { get; set; }
	
		/// <summary>
		/// 	Can be absent.
		/// </summary>
		public BlogEntry BlogEntry { get; set; }
	
		/// <summary>
		/// 	Can be absent.
		/// </summary>
		public Comment Comment { get; set; }
	
	}
}