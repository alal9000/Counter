using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Clock
    {
        private Counter _seconds;
        private Counter _minutes;
        private Counter _hours;

        public Clock(string name)
        {
            _seconds = new Counter(name + " seconds");
            _minutes = new Counter(name + " minutes");
            _hours = new Counter(name + " hours");
        }

        public void Tick()
        {
            _seconds.Increment();

            if (_seconds.Ticks == 60)
            {
                _seconds.Reset();
                _minutes.Increment();
            }

            if (_minutes.Ticks == 60)
            {
                _minutes.Reset();
                _hours.Increment();
            }

            if (_hours.Ticks == 24)
            {
                this.Reset();
            }
        }

        public void Reset()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }

        public void GetCurrentTime()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", 
                _hours.Ticks, 
                _minutes.Ticks, 
                _seconds.Ticks
            );          
        }


    }
}
