using System.Runtime.Serialization;

namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	 Can be absent. 
	/// </summary>
	public enum SubmissionVerdictEnum
	{
		[EnumMember(Value = "FAILED")]
		Failed,
		[EnumMember(Value = "OK")]
		Ok,
		[EnumMember(Value = "PARTIAL")]
		Partial,
		[EnumMember(Value = "COMPILATION_ERROR")]
		CompilationError,
		[EnumMember(Value = "RUNTIME_ERROR")]
		RuntimeError,
		[EnumMember(Value = "WRONG_ANSWER")]
		WrongAnswer,
		[EnumMember(Value = "PRESENTATION_ERROR")]
		PresentationError,
		[EnumMember(Value = "TIME_LIMIT_EXCEEDED")]
		TimeLimitExceeded,
		[EnumMember(Value = "MEMORY_LIMIT_EXCEEDED")]
		MemoryLimitExceeded,
		[EnumMember(Value = "IDLENESS_LIMIT_EXCEEDED")]
		IdlenessLimitExceeded,
		[EnumMember(Value = "SECURITY_VIOLATED")]
		SecurityViolated,
		[EnumMember(Value = "CRASHED")]
		Crashed,
		[EnumMember(Value = "INPUT_PREPARATION_CRASHED")]
		InputPreparationCrashed,
		[EnumMember(Value = "CHALLENGED")]
		Challenged,
		[EnumMember(Value = "SKIPPED")]
		Skipped,
		[EnumMember(Value = "TESTING")]
		Testing,
		[EnumMember(Value = "REJECTED")]
		Rejected,
	}
}