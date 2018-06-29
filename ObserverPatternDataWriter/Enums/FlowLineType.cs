using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDataWriter.Enums
{
    /// <summary>
    /// Indentifies the status of a TAF test item
    /// </summary>
    public enum FlowLineType
    {
        /// <summary>
        /// Item is started
        /// </summary>
        Start,
        /// <summary>
        /// Item is ended
        /// </summary>
        End,
        /// <summary>
        /// Item is aborted
        /// </summary>
        Abort
    }
}
