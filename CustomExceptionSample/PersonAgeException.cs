using System;

namespace CustomExceptionSample
{
    public class PersonAgeException : Exception
    {
        public int Value { get; }
        public PersonAgeException(string message, int value) : base(message)
        {
            Value = value;
        }
    }
}