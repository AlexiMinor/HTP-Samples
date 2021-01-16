using System;

namespace SerializationSample
{
    [Serializable]
    public abstract class Animal
    {
        public virtual int Age
        {
            get;
            set;
        }
    }
}