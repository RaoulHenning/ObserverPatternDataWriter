using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDataWriter
{
    public interface ITafReport
    {
        void WriteReportLine(string message);
    }
}
