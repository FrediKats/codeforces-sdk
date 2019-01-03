using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	 Scoring system used for the contest. 
	/// </summary>
	public enum ContestTypeEnum
	{
		[EnumMember(Value = "CF")]
		Cf,
		[EnumMember(Value = "IOI")]
		Ioi,
		[EnumMember(Value = "ICPC")]
		Icpc,
	}
}