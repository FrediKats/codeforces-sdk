namespace CodeforcesApiWrapper.Types
{
	/// <summary>
	/// 	Represents a submission.
	/// </summary>
	public class Submission
	{
		public int Id { get; set; }
		/// <summary>
		/// 	Can be absent.
		/// </summary>
		public int ContestId { get; set; }
		/// <summary>
		/// 	Time, when submission was created, in unix-format.
		/// </summary>
		public int CreationTimeSeconds { get; set; }
		/// <summary>
		/// 	Number of seconds, passed after the start of the contest (or a virtual start for virtual parties), before the submission.
		/// </summary>
		public int RelativeTimeSeconds { get; set; }
		public Problem Problem { get; set; }
		public Party Author { get; set; }
		public string ProgrammingLanguage { get; set; }
		/// <summary>
		/// 	Enum: FAILED, OK, PARTIAL, COMPILATION_ERROR, RUNTIME_ERROR, WRONG_ANSWER, PRESENTATION_ERROR, TIME_LIMIT_EXCEEDED, MEMORY_LIMIT_EXCEEDED, IDLENESS_LIMIT_EXCEEDED, SECURITY_VIOLATED, CRASHED, INPUT_PREPARATION_CRASHED, CHALLENGED, SKIPPED, TESTING, REJECTED. Can be absent.
		/// </summary>
		public SubmissionVerdictEnum Verdict { get; set; }
		/// <summary>
		/// 	Enum: SAMPLES, PRETESTS, TESTS, CHALLENGES, TESTS1, ..., TESTS10. Testset used for judging the submission.
		/// </summary>
		public SubmissionTestsetEnum Testset { get; set; }
		/// <summary>
		/// 	Number of passed tests.
		/// </summary>
		public int PassedTestCount { get; set; }
		/// <summary>
		/// 	Maximum time in milliseconds, consumed by solution for one test.
		/// </summary>
		public int TimeConsumedMillis { get; set; }
		/// <summary>
		/// 	Maximum memory in bytes, consumed by solution for one test.
		/// </summary>
		public int MemoryConsumedBytes { get; set; }
	}
}