using System;

namespace SerializationSample
{
    [Serializable]
    public struct SpecialStructure
    {
        public int Number { get; set; }
        public string Value { get; set; }
    }
}