using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDataWriter.Enums
{
    /// <summary>
    /// Indentifies the type of an output line of the TAF test script.
    /// </summary>
    [Flags]
    public enum LineType
    {
        /// <summary>
        /// The line type is unknown
        /// </summary>
        Unknown = 0x0000,
        /// <summary>
        /// This line displayes information about the TAF test item being executed
        /// </summary>
        Informational = 0x0001,
        /// <summary>
        /// This line logs a warning about a TAF test item being executed
        /// </summary>
        Warning = 0x0002,
        /// <summary>
        /// This line logs a failure of a TAF test item being executed
        /// </summary>
        Failure = 0x0004,
        /// <summary>
        /// This line logs a successfull action of a TAF test item being executed
        /// </summary>
        Success = 0x0008,
        /// <summary>
        /// This line logs a debug statement from a TAF test item being executed
        /// </summary>
        Debug = 0x0010,
        /// <summary>
        /// This line contains measurement data
        /// </summary>
        MeasurementTag = 0x0020,
        /// <summary>
        /// This line contains detailed information about a TAF test item being executed
        /// </summary>
        Verbose = 0x0040,
        /// <summary>
        /// This line contains a control command for the report generators (e.g. to include a text file in the report)
        /// </summary>
        ReportCommand = 0x0080,
        /// <summary>
        /// This line is skipped
        /// </summary>
        Skipped = 0x0100,
        /// <summary>
        /// This line contains version information (about the SUT, a sub-system of the SUT, an external device etc.)
        /// </summary>
        VersionInfo = 0x0200
    }
}
