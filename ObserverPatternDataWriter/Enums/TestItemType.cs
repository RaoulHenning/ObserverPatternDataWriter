namespace ObserverPatternDataWriter.Enums
{
    /// <summary>
    /// Identifies a TAF test item
    /// </summary>
    public enum TestItemType
    {
        /// <summary>
        /// Identifies a TAF test item of type "Test Run"
        /// </summary>
        TestRun,
        /// <summary>
        /// Identifies a TAF test item of type "Test Batch"
        /// </summary>
        TestBatch,
        /// <summary>
        /// Identifies a TAF test item of type "Test Case". This is a test case that is executed in the loop of test cases.
        /// </summary>
        NormalTestCase,
        /// <summary>
        /// Identifies a TAF test item of type "Test Case". This is the test case that is executed before the loop of test cases is started.
        /// </summary>
        PreLoopTestCase,
        /// <summary>
        /// Identifies a TAF test item of type "Test Case". This is the test case that is executed before the loop of test cases has finished.
        /// </summary>
        PostLoopTestCase,
        /// <summary>
        /// Identifies a TAF test item of type "Test Case". This is the test case that is executed between each loop of test cases.
        /// </summary>
        BetweenLoopsTestCase,
        /// <summary>
        /// Identifies a TAF test item of type "Test Case". This is a test case that is called from another test case.
        /// </summary>
        NestedTestCase,
        /// <summary>
        /// Identifies a TAF test item of type "Loop" (i.e. a loop of test cases)
        /// </summary>
        Loop,
        /// <summary>
        /// Identifies a TAF test item of type "Keyword"
        /// </summary>
        Keyword,
        /// <summary>
        /// Identifies a TAF test item of type "Script Output Line"
        /// </summary>
        ScriptOutputLine,
        /// <summary>
        /// Identifies an unknown TAF test item type
        /// </summary>
        Unknown
    }
}
