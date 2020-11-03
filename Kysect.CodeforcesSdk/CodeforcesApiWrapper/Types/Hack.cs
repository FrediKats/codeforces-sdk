using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	Represents a hack, made during Codeforces Round.
	/// </summary>
	public class Hack
	{
		public int Id { get; set; }
	
		/// <summary>
		/// 	Hack creation time in unix format.
		/// </summary>
		public int CreationTimeSeconds { get; set; }
	
		public Party Hacker { get; set; }
	
		public Party Defender { get; set; }
	
		/// <summary>
		/// 	Enum: HACK_SUCCESSFUL, HACK_UNSUCCESSFUL, INVALID_INPUT, GENERATOR_INCOMPILABLE, GENERATOR_CRASHED, IGNORED, TESTING, OTHER. Can be absent.
		/// </summary>
		public HackVerdictEnum Verdict { get; set; }
	
		/// <summary>
		/// 	Hacked problem.
		/// </summary>
		public Problem Problem { get; set; }
	
		/// <summary>
		/// 	Can be absent.
		/// </summary>
		public string Test { get; set; }
	
		/// <summary>
		/// 	Field manual can have values &quot;true&quot; and &quot;false&quot;. If manual is &quot;true&quot; then test for the hack was entered manually. Fields &quot;protocol&quot; and &quot;verdict&quot; contain human-readable description of judge protocol and hack verdict. Localized. Can be absent.
		/// </summary>
		public object JudgeProtocol { get; set; }
	
	}
}