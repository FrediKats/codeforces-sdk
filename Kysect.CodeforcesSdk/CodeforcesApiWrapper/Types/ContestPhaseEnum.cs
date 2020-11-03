using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	public enum ContestPhaseEnum
	{
		[EnumMember(Value = "BEFORE")]
		Before,
		[EnumMember(Value = "CODING")]
		Coding,
		[EnumMember(Value = "PENDING_SYSTEM_TEST")]
		PendingSystemTest,
		[EnumMember(Value = "SYSTEM_TEST")]
		SystemTest,
		[EnumMember(Value = "FINISHED")]
		Finished,
	}
}