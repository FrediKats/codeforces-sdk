using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	public enum SubmissionTestsetEnum
	{
		[EnumMember(Value = "SAMPLES")]
		Samples,
		[EnumMember(Value = "PRETESTS")]
		Pretests,
		[EnumMember(Value = "TESTS")]
		Tests,
		[EnumMember(Value = "CHALLENGES")]
		Challenges,
		[EnumMember(Value = "TESTS1")]
		Tests1,
		[EnumMember(Value = "TESTS10")]
		Tests10,
	}
}