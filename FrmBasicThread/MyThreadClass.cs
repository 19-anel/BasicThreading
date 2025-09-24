using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 1; loopCount <= 10; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

               Thread.Sleep(1500);
            }
        }
    }
}
