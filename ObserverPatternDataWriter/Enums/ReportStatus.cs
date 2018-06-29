using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDataWriter.Enums
{
    /// <summary>
    /// When a report line has more data fields, they are seperated by this
    /// </summary>
    public enum ReportStatus
    {
        ReportStepPassed,               // P
        ReportStepFailed,               // F
        ReportStepSkipped,              // S
        ReportStepManualExecuted,       // M
        ReportInterfaceDeviation,       // C
        ReportLogInfo,                  // L
        ReportDebug,                    // D
        ReportReportInfo,               // R
        ReportReportWarning,            // W
        ReportDioRetry,                 // D
        ReportMeasurement,              // X
        ReportCommand,                  // I
        ReportVersionInfo,              // V
        ControlMarker,                  // T
        FlowStartTestBatchInfo,         // G
        FlowEndTestBatchInfo,           // G
        FlowControlStatement,           // O
        SetoolMessage
    }
}
