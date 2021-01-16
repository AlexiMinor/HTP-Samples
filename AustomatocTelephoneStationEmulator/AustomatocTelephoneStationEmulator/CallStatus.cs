namespace AutomaticTelephoneStationEmulator
{
    public enum CallStatus
    {
        Active,
        Accepted,
        SenderNonAvailable,
        SenderNonActive,
        RecieverNonAvailable,
        RecieverNonActive,
        Rejected,
        NumberNotInService,
        InsufficientFunds
    }
}