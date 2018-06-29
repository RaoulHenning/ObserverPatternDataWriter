using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternDataWriter.Enums;
using ObserverPatternDataWriter.ScriptOutputHandling;

namespace ObserverPatternDataWriter
{
    public class TafTextReport : IObserver<TafReportLine>
    {
        private IDisposable _cancellation;
        private readonly StreamWriter _textWriter;
        private readonly List<char> _writtenTags;
        private readonly List<char> _storedTags;
        private int _lineNr;
        public TafTextReport(string reportFilePath)
        {
            _textWriter = new StreamWriter(reportFilePath) {AutoFlush = false};
        }
        public virtual void Subscribe(TafReportHandler provider)
        {
            _cancellation = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
        }
        public void OnNext(TafReportLine value)
        {
            var reportIndicator = GetIndicator(value.ReportStatus);
            if (string.IsNullOrEmpty(reportIndicator))
            {
                
            }



        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            Console.WriteLine("TafTextReport Finished");
        }

        private void WriteReportLine(string receivedString, bool isSetoolString)
        {
            // Remove linefeeds and vertical tabs
            receivedString = receivedString.Replace((char)10, (char)0);
            receivedString = receivedString.Replace((char)10, (char)0);


        }

        private string GetIndicator(ReportStatus reportStatus)
        {
            switch (reportStatus)
            {
                case ReportStatus.ReportStepPassed:
                    return "C";
                case ReportStatus.ReportStepFailed:
                    return "R";
                case ReportStatus.ReportStepSkipped:
                    return "W";
                case ReportStatus.ReportStepManualExecuted:
                    return "L";
                case ReportStatus.ReportInterfaceDeviation:
                    return "B";
                case ReportStatus.ReportLogInfo:
                    return "D";
                case ReportStatus.ReportDebug:
                    return "F";
                case ReportStatus.ReportReportInfo:
                    return "M";
                case ReportStatus.ReportReportWarning:
                    return "P";
                case ReportStatus.ReportDioRetry:
                    return "S";
                case ReportStatus.ReportMeasurement:
                    return "X";
                case ReportStatus.ReportCommand:
                    return "I";
                case ReportStatus.ReportVersionInfo:
                    return "V";
                case ReportStatus.ControlMarker:
                    return "T";
                case ReportStatus.FlowStartTestBatchInfo:
                    return "G";
                case ReportStatus.FlowEndTestBatchInfo:
                    return "G";
                case ReportStatus.FlowControlStatement:
                    return "O";
                case ReportStatus.SetoolMessage:
                    return string.Empty;
                default:
                    return "F";
            }
        }
    }
}
