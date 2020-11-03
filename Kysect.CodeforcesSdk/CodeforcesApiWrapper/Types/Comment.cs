using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	Represents a comment.
	/// </summary>
	public class Comment
	{
		public int Id { get; set; }
	
		/// <summary>
		/// 	Time, when comment was created, in unix format.
		/// </summary>
		public int CreationTimeSeconds { get; set; }
	
		public string CommentatorHandle { get; set; }
	
		public string Locale { get; set; }
	
		public string Text { get; set; }
	
		/// <summary>
		/// 	Can be absent.
		/// </summary>
		public int ParentCommentId { get; set; }
	
		public int Rating { get; set; }
	
	}
}