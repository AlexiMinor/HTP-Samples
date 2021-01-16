using System;

namespace AutomaticTelephoneStationEmulator.EventArgsModels
{
    public class CallEventArgs
    {
        public Guid SenderId { get; set; }
        public Guid RecieverId { get; set; }
    }
 
}