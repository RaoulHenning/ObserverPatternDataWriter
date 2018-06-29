using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternDataWriter.ScriptOutputHandling;

namespace ObserverPatternDataWriter
{
    public class TafTextReport : IObserver<TafScriptLineBase>
    {
        private IDisposable _cancellation;
        public TafTextReport()
        {
            
        }
        public virtual void Subscribe(TafReportHandler provider)
        {
            _cancellation = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
        }
        public void OnNext(TafScriptLineBase value)
        {
            Console.WriteLine(value.ToString());
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            Console.WriteLine("TafTextReport Finished");
        }
    }
}
