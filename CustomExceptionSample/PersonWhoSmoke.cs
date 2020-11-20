using System;

namespace CustomExceptionSample
{
    class PersonWhoSmoke
    {
        public string Name { get; set; }

        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value < 18)
                {
                    throw new PersonAgeException("You have no permission", value);
                }

                _age = value;
            }
        }
    }
}