using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
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