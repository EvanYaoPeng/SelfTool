using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.Name = "Main";

            //// Create a task and supply a user delegate by using a lambda expression. 
            //Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
            //// Start the task.
            //taskA.Start();

            //// Output a message from the calling thread.
            //Console.WriteLine("Hello from thread '{0}'.",
            //                  Thread.CurrentThread.Name);
            //taskA.Wait();

            ParallelDemo pd = new ParallelDemo();
            //pd.ParallelInvokeMethod();
            //pd.ParallelForMethod();
            //pd.ParallelForMethodCommon();

            //pd.TestPLinq();

            //PEnumerable.ListWithParallel();

            //PEnumerable.ConcurrentBagWithPallelAndDetails();

            TaskDemo td = new TaskDemo();
            td.Tesk();
            Console.Read();
        }


    }

 
}
