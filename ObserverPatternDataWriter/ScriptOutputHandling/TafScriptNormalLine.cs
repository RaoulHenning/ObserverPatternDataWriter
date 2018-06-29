using System.Text;
using ObserverPatternDataWriter.Enums;

namespace ObserverPatternDataWriter.ScriptOutputHandling
{
    /// <summary>
    /// Class that represents a "normal" script output message. (i.e. a script output line that logs info, a warning, an error, etc.)
    /// </summary>
    public class TafScriptNormalLine : TafScriptLineBase
    {
        public LineType LineType { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lineNr"></param>
        /// <param name="timeStamp"></param>
        /// <param name="lineType"></param>
        /// <param name="identifier"></param>
        /// <param name="enabled"></param>
        public TafScriptNormalLine(int lineNr, string timeStamp, LineType lineType, string identifier, bool enabled) 
            : base(lineNr, timeStamp, lineType.ToString(), identifier, enabled)
        {
            LineType = lineType;
        }
        public string ToString(int indent)
        {
            var sb = new StringBuilder();
            while (indent != 0)
            {
                sb.Append("  ");

                indent--;
            }
            return $"{$"{sb.ToString()}{Type}",-30} {Timestamp,-30} {Value}";
        }

        public override string ToString()
        {
            return $"{Type,-30} {Timestamp,-30} {Value}";
        }

       
    }
}
