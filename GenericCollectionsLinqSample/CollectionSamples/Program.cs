using System;
using System.Collections; // non generic collection
using System.Collections.Generic; // generic collection
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq; //multithreading collections

namespace CollectionSamples
{
    class Program
    {

        static void Main(string[] args)
        {
            ObservableSample();
        }

        static void ObservableSample()
        {
            ObservableCollection<string> collection = new ObservableCollection<string>() { "aaa", "bbbb", "cccc" };

            collection.CollectionChanged += ObservableCollectionChangeHandler;

            collection.Add("ddd");
            collection.RemoveAt(collection.Count-1);
            collection[1] = "bbb";
        }

        private static void ObservableCollectionChangeHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine($"Element {e.NewItems[0]} was added");
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine($"Element {e.OldItems[0]} was removed");
            }
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine($"Element {e.OldItems[0]} was replaced on {e.NewItems[0]}");
            }
        }

        static void ListSampleMethod()
        {
            var list = new List<int>();// empty

            list.Add(5); // {5} //void

            var intArray = new int[] { 1, 2, 3, 4, 5 };
            list.AddRange(intArray); //{5, 1,2...5}

            var firstElementInListIndex = list.IndexOf(5); //0 
            list.Insert(3, 15); //5, 1,2,15, 3-5{}
            list.InsertRange(3, list);

            var resultOfRemoving = list.Remove(45);
            list.RemoveAt(1);

            list.Sort();
            var index = list.BinarySearch(1555);
        }

        static void LinkedListSampleMethod()
        {
            var list = new LinkedList<string>();

            list.AddLast("world");
            list.AddFirst("Hello");
            list.AddBefore(list.First, "Beautiful");

            LinkedListNode<string> nodeElement = list.First;

            var element3rd = nodeElement.Next.Next.Previous;



        }

        static void DictionarySampleMethod()
        {
            var dict = PersonDictionaryGenerator();

            var sw = new Stopwatch();
            sw.Start();
            var x = dict["Bill"];

            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            //var list = dict.Values.ToList();

            //sw.Restart();
            //foreach (var person in list)
            //{
            //    if (person.Name == "Bill")
            //    {
            //        break;
            //    }
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedTicks);

            var hastSet = new HashSet<string>();
            
        }

        public static string RandomString()
        {
            var guid = Guid.NewGuid();
            return guid.ToString("D");
        }
       
        static Dictionary<string, Person> PersonDictionaryGenerator()
        {
            var dict = new Dictionary<string, Person>();
            for (int i = 0; i < 10000000; i++)
            {
                var name = RandomString();
                var lastName = RandomString();
                var dateOfBirth = DateTime.Now;
                if (i == 9999999)
                {
                    dict.Add("Bill", new Person()
                    {
                        Name = "Bill",
                        LastName = "Gates",
                        DateOfBirth = dateOfBirth
                    });
                }
                else
                {
                    dict.Add(name, new Person()
                    {
                        Name = name,
                        LastName = lastName,
                        DateOfBirth = dateOfBirth
                    });
                }
            }
            return dict;
        }

        static void QueueSample()
        {
            var queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");
         
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(queue.Count);
            Console.WriteLine(Environment.NewLine);


            var data = queue.Dequeue();
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(queue.Count);
            Console.WriteLine(Environment.NewLine);

            var data2 = queue.Peek();
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(queue.Count);
        }

        static void StackSample()
        {
            var queue = new Stack<string>();
            queue.Push("a");
            queue.Push("b");
            queue.Push("c");
            queue.Push("d");
            queue.Push("e");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(queue.Count);
            Console.WriteLine(Environment.NewLine);


            var data = queue.Pop();
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(queue.Count);
            Console.WriteLine(Environment.NewLine);

            var data2 = queue.Peek();
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(queue.Count);
        }

        static void ForeachUsingWhileSample()
        {
            var list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            IEnumerator enumerator = list.GetEnumerator();


            while (enumerator.MoveNext())
            {
                var item = (int)enumerator.Current;
                Console.WriteLine(item);
            }
            enumerator.Reset();

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
