using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	public enum ProblemTypeEnum
	{
		[EnumMember(Value = "PROGRAMMING")]
		Programming,
		[EnumMember(Value = "QUESTION")]
		Question,
	}
}