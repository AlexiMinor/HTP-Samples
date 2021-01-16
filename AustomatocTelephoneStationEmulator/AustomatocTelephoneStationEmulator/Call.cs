using System;

namespace AutomaticTelephoneStationEmulator
{
    public class Call
    {
        public Contract From { get; }
        public Contract To { get; }
        public TimeSpan Duration { get; }
        public DateTime StarTime { get; }
        public CallStatus Status { get; }
        public Call(Contract from, Contract to, TimeSpan duration, CallStatus status)
        {
            From = from;
            To = to;
            Duration = duration;
            Status = status;
            StarTime = DateTime.Now;
        }
    }
}