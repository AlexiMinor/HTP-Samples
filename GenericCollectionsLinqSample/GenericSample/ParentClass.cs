namespace GenericSample
{
    public class ParentClass<T> 
    {
        public T Id { get; set; }

        public ParentClass(T id)
        {
            Id = id;
        }
    }
}