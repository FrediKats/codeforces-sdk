using System.Runtime.Serialization;

namespace Kysect.CodeforcesSdk.Types
{
	/// <summary>
	/// 	 Can be absent. 
	/// </summary>
	public enum HackVerdictEnum
	{
		[EnumMember(Value = "HACK_SUCCESSFUL")]
		HackSuccessful,
		[EnumMember(Value = "HACK_UNSUCCESSFUL")]
		HackUnsuccessful,
		[EnumMember(Value = "INVALID_INPUT")]
		InvalidInput,
		[EnumMember(Value = "GENERATOR_INCOMPILABLE")]
		GeneratorIncompilable,
		[EnumMember(Value = "GENERATOR_CRASHED")]
		GeneratorCrashed,
		[EnumMember(Value = "IGNORED")]
		Ignored,
		[EnumMember(Value = "TESTING")]
		Testing,
		[EnumMember(Value = "OTHER")]
		Other,
	}
}