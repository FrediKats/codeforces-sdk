using System.Runtime.Serialization;

namespace Kysect.CodeforcesSdk.Types
{
	public enum PartyParticipantTypeEnum
	{
		[EnumMember(Value = "CONTESTANT")]
		Contestant,
		[EnumMember(Value = "PRACTICE")]
		Practice,
		[EnumMember(Value = "VIRTUAL")]
		Virtual,
		[EnumMember(Value = "MANAGER")]
		Manager,
		[EnumMember(Value = "OUT_OF_COMPETITION")]
		OutOfCompetition,
	}
}