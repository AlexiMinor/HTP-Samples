using System;

namespace GenericSample
{
    public class ChildClass1<T> : ParentClass<T> 
    {
        public ChildClass1(T id) : base(id)
        {

        }
    }

    public class ChildClass2 : ParentClass<int>
    {
        public ChildClass2(int id) : base(id)
        {

        }
    }

    public class ChildClass3<T, TK> : ParentClass<T> where TK : struct
    {
        public ChildClass3(T id) : base(id)
        {

        }
    }
}