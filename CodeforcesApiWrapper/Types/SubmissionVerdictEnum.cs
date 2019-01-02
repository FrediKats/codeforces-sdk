namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	 Can be absent. 
	/// </summary>
	public enum SubmissionVerdictEnum
	{
		Failed,
		Ok,
		Partial,
		CompilationError,
		RuntimeError,
		WrongAnswer,
		PresentationError,
		TimeLimitExceeded,
		MemoryLimitExceeded,
		IdlenessLimitExceeded,
		SecurityViolated,
		Crashed,
		InputPreparationCrashed,
		Challenged,
		Skipped,
		Testing,
		Rejected,
	}
}