using System;
using System.Threading;

namespace SemaphoreSample
{
    public class Train
    {
        static readonly Semaphore Semaphore = new Semaphore(5, 5);

        private readonly Thread _thread;

        private int _count = 3;

        public Train(Guid id)
        {
            //DONT DO AS IN THE SAMPLE
            _thread = new Thread(MoveToTheStation) { Name = id.ToString("D") };
            _thread.Start();
        }

        public void MoveToTheStation()
        {
            while (_count > 0)
            {
                Semaphore.WaitOne();
                Console.WriteLine($"Train {Thread.CurrentThread.Name} on the station");

                Thread.Sleep(500);

                Console.WriteLine($"Train {Thread.CurrentThread.Name} move from the station");

                Semaphore.Release();

                _count--;
                Thread.Sleep(200);
            }
        }
    }
}