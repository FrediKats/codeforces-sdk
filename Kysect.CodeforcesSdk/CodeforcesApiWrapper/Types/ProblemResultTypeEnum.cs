using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	 If type is PRELIMINARY then points can decrease (if, for example, solution will fail during system test).  Otherwise, party can only increase points for this problem by submitting better solutions. 
	/// </summary>
	public enum ProblemResultTypeEnum
	{
		[EnumMember(Value = "PRELIMINARY")]
		Preliminary,
		[EnumMember(Value = "FINAL")]
		Final,
	}
}