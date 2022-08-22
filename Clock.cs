using System;
namespace Clock
{
    public class Clock
    {
        private Counter _seconds;
        private Counter _minutes;
        private Counter _hours;

        public Clock()
        {
            _seconds = new Counter("seconds");
            _minutes = new Counter("minutes");
            _hours = new Counter("hours");
        }

        public void Tick()
        {
            _seconds.Increment();
            if (_seconds.Ticks == 60)
            {
                _minutes.Increment();
                _seconds.Reset();
            }

            if (_minutes.Ticks == 60)
            {
                _hours.Increment();
                _minutes.Reset();
            }

            if (_hours.Ticks == 24)
            {
                _hours.Reset();
            }

        }

        public void Reset()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }

        public string Time
        {
            get
            {
                string s = _hours.Ticks.ToString("D2") + ":" + _minutes.Ticks.ToString("D2") + ":" + _seconds.Ticks.ToString("D2");
                return s;
            }
        }
    }
}
