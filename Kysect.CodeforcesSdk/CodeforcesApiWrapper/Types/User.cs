using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	Represents a Codeforces user.
	/// </summary>
	public class User
	{
		/// <summary>
		/// 	Codeforces user handle.
		/// </summary>
		public string Handle { get; set; }
	
		/// <summary>
		/// 	Shown only if user allowed to share his contact info.
		/// </summary>
		public string Email { get; set; }
	
		/// <summary>
		/// 	User id for VK social network. Shown only if user allowed to share his contact info.
		/// </summary>
		public string VkId { get; set; }
	
		/// <summary>
		/// 	Shown only if user allowed to share his contact info.
		/// </summary>
		public string OpenId { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string FirstName { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string LastName { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string Country { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string City { get; set; }
	
		/// <summary>
		/// 	Localized. Can be absent.
		/// </summary>
		public string Organization { get; set; }
	
		/// <summary>
		/// 	User contribution.
		/// </summary>
		public int Contribution { get; set; }
	
		/// <summary>
		/// 	Localized.
		/// </summary>
		public string Rank { get; set; }
	
		public int Rating { get; set; }
	
		/// <summary>
		/// 	Localized.
		/// </summary>
		public string MaxRank { get; set; }
	
		public int MaxRating { get; set; }
	
		/// <summary>
		/// 	Time, when user was last seen online, in unix format.
		/// </summary>
		public int LastOnlineTimeSeconds { get; set; }
	
		/// <summary>
		/// 	Time, when user was registered, in unix format.
		/// </summary>
		public int RegistrationTimeSeconds { get; set; }
	
		/// <summary>
		/// 	Amount of users who have this user in friends.
		/// </summary>
		public int FriendOfCount { get; set; }
	
		/// <summary>
		/// 	User's avatar URL.
		/// </summary>
		public string Avatar { get; set; }
	
		/// <summary>
		/// 	User's title photo URL.
		/// </summary>
		public string TitlePhoto { get; set; }
	
	}
}