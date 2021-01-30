using System.Runtime.Serialization;

namespace Kysect.CodeforcesSdk.Types
{
	public enum ProblemTypeEnum
	{
		[EnumMember(Value = "PROGRAMMING")]
		Programming,
		[EnumMember(Value = "QUESTION")]
		Question,
	}
}