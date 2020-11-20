namespace ClassSample
{
    public class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        Owner CatOwner { get; set; }

        public void SampleMethod()
        {
            var owner = new Owner();
        }

        class Owner
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

    }
}
