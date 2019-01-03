using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	 Can be absent. 
	/// </summary>
	public enum HackVerdictEnum
	{
		HackSuccessful,
		HackUnsuccessful,
		InvalidInput,
		GeneratorIncompilable,
		GeneratorCrashed,
		Ignored,
		Testing,
		Other,
	}
}