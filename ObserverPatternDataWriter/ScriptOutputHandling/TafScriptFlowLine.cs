using System;
using System.Text;
using ObserverPatternDataWriter.Enums;

namespace ObserverPatternDataWriter.ScriptOutputHandling
{
    /// <summary>
    /// Class that represents a script output message that marks the start or end of a test item (e.g. test batch, test case, keyword, loop, etc.)
    /// </summary>
    public class TafScriptFlowLine : TafScriptLineBase
    {
        public FlowLineType FlowLineType { get; }
        public TestItemType TestItemType { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lineNr">The line number in the test script output that represents the start of this item</param>
        /// <param name="timeStamp">The time and data of the moment this item was started</param>
        /// <param name="flowLineType">Marks if the item was started, ended or aborted</param>
        /// <param name="testItemType">The type of the item (Loop, Test batch etc.)</param>
        /// <param name="identifier">The name of the item</param>
        /// <param name="enabled">True if the item is executed;False otherwise</param>
        public TafScriptFlowLine(int lineNr, string timeStamp, FlowLineType flowLineType, TestItemType testItemType, string identifier, bool enabled) 
            : base(lineNr, timeStamp, testItemType.ToString(), identifier, enabled)
        {
            FlowLineType = flowLineType;
            TestItemType = testItemType;

            if (TestItemType == TestItemType.TestBatch || TestItemType == TestItemType.NormalTestCase)
            {
                Value = Value.Replace(".xml", "");
                Value = Value.Replace(".xls", "");
            }
            if (TestItemType != TestItemType.NormalTestCase) return;         
            if (!Value.Contains("(")) return;

            // The test case identifiers also contain the type of test case. Move this to the type field i.s.o. the value field
            Value = $"{Value} {Value.Substring(Value.IndexOf("(", StringComparison.Ordinal))}";
            Value = Value.Substring(0, Value.IndexOf("(", StringComparison.Ordinal));
        }

        /// <summary>
        /// Default string representation of this message, using a given indent.
        /// </summary>
        public string ToString(int indent)
        {
            var sb = new StringBuilder();

            while (indent != 0)
            {
                sb.Append("  ");

                indent--;
            }

            return $"{$"{sb}{TestItemType}.{FlowLineType}",-30} {Timestamp,-30} {Value}";
        }

        /// <summary>
        /// Default string representation of this message.
        /// </summary>
        public override string ToString()
        {
            return $"{$"{TestItemType}.{FlowLineType}",-30} {Timestamp,-30} {Value}";
        }
    }
}
