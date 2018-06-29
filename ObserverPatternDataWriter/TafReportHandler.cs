using System;
using System.Collections.Generic;
using ObserverPatternDataWriter.ScriptOutputHandling;

namespace ObserverPatternDataWriter
{
    public class TafReportHandler : IObservable<TafReportLine>
    {
        private List<IObserver<TafReportLine>> _observers;
        private List<TafReportLine> _scriptOutputLines;

        public TafReportHandler()
        {
            _observers = new List<IObserver<TafReportLine>>();
            _scriptOutputLines = new List<TafReportLine>();
        }

        public IDisposable Subscribe(IObserver<TafReportLine> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);             
            }
            return new Unsubscriber<TafReportLine>(_observers, observer);
        }

        public void HandleOutputLine(TafReportLine tafReportLine)
        {
            _scriptOutputLines.Add(tafReportLine);

            foreach (var observer in _observers)
            {
                observer.OnNext(tafReportLine);
            }
        }


        public void TafReportingCompleted()
        {
            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }
            _observers = null;
            _scriptOutputLines = null;
        }
        public IReadOnlyList<string> GetScriptOutputLines()
        {
            return _scriptOutputLines;
        }


    }
}
