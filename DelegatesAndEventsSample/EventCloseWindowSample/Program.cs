using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EventCloseWindowSample
{
    enum CtrlType
    {
        CTRL_C_EVENT = 0,
        CTRL_BREAK_EVENT = 1,
        CTRL_CLOSE_EVENT = 2,
        CTRL_LOGOFF_EVENT = 5,
        CTRL_SHUTDOWN_EVENT = 6
    }

    class Program
    {
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);

        private delegate bool EventHandler(CtrlType arg);

        private static EventHandler _handler;

        private static bool Handle(CtrlType arg)
        {
            switch (arg)
            {
                case CtrlType.CTRL_CLOSE_EVENT:
                    for (int i = 0; i < 10000; i++)
                    {
                        Console.WriteLine("App Finished");
                    }

                    return false;

                case CtrlType.CTRL_C_EVENT:
                case CtrlType.CTRL_LOGOFF_EVENT:
                case CtrlType.CTRL_SHUTDOWN_EVENT:
                default:
                    return false;
            }
        }

        static void Main(string[] args)
        {
            _handler += new EventHandler(Handle);
            SetConsoleCtrlHandler(_handler, true);
            for (int i = 0; i < 100000000000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
