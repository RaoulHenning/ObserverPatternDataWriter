namespace ObserverPatternDataWriter.ScriptOutputHandling
{
    /// <summary>
    /// Base class for classes that store script messages
    /// </summary>
    public abstract class TafScriptLineBase
    {
        public int LineNr { get; set; }
        public string Timestamp { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Enabled { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lineNr">The line number in the test script output that represents this item or the start of this item</param>
        /// <param name="timeStamp">The time and data of the moment this item was executed</param>
        /// <param name="type">The type of this item (test item type or line type)</param>
        /// <param name="value">The output string of the script</param>
        /// <param name="enabled">True if this item was enabled; False otherwise</param>
        protected TafScriptLineBase(int lineNr, string timeStamp, string type, string value, bool enabled)
        {
            LineNr = lineNr;
            Timestamp = timeStamp;
            Type = type;
            Value = value;
            Enabled = enabled;
        }
    }
}
