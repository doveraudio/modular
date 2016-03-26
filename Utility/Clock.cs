using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Modular.Utility
{
   public class Clock
    {
        private bool _running;
        private DispatcherTimer _timer;
        private int _interval;
        public int Interval { get { return _interval; } set { _interval = value; } }
        
        public event EventHandler OnTick
        {
            add
            {

                _timer.Tick += value;
            }
            remove
            {
                _timer.Tick -= value;
            }
        }
        public void Start()
        {
            _running = true;
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, this._interval);
            _timer.Start();
        }

        public void Stop()
        {
            _running = false;
            _timer.Stop();
        }
    }
}
