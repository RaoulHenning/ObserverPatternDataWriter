using System;
using System.Collections.Generic;

namespace ObserverPatternDataWriter
{
    internal class Unsubscriber<T> : IDisposable
    {
        private List<IObserver<T>> _observers;
        private IObserver<T> _observer;

        ~Unsubscriber()
        {
            Dispose(false);
        }
        internal Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (disposing)
            {
                _observers = null;
                _observer = null;
            }
            // get rid of unmanaged resources

        }
    }
}