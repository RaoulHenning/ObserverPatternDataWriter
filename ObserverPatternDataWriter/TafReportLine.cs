using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternDataWriter.Enums;

namespace ObserverPatternDataWriter
{
    public class TafReportLine
    {
        public ReportStatus ReportStatus { get; set; }
        public string Message { get; set; }
    }
}
