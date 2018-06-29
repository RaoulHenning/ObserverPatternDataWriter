using System;
using System.Collections.Generic;
using ObserverPatternDataWriter.ScriptOutputHandling;

namespace ObserverPatternDataWriter
{
    public class TafReportHandler : IObservable<TafScriptLineBase>
    {
        private List<IObserver<TafScriptLineBase>> _observers;
        private List<TafScriptLineBase> _scriptOutputLines;

        public TafReportHandler()
        {
            _observers = new List<IObserver<TafScriptLineBase>>();
            _scriptOutputLines = new List<TafScriptLineBase>();
        }

        public IDisposable Subscribe(IObserver<TafScriptLineBase> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);             
            }
            return new Unsubscriber<TafScriptLineBase>(_observers, observer);
        }

        public void HandleOutputLine(TafScriptLineBase tafScriptOutputLine)
        {
            _scriptOutputLines.Add(tafScriptOutputLine);

            foreach (var observer in _observers)
            {
                observer.OnNext(tafScriptOutputLine);
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
        public IReadOnlyList<TafScriptLineBase> GetScriptOutputLines()
        {
            return _scriptOutputLines;
        }


    }
}
