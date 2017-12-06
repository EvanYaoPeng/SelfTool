using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelT
{
    public class TaskDemo
    {
        public void Tesk()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Hello,task");
            });
            task1.Start();

            var task2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello,task started by task factory");
            });
        }
        /// <summary>
        /// task two
        /// </summary>
        public void TaskTwo()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Finish");
            });
            Console.WriteLine("Before start:" + task1.Status);
            task1.Start();
            Console.WriteLine("After start:" + task1.Status);
            task1.Wait();
            Console.WriteLine("After Finish:" + task1.Status);

        }
        /// <summary>
        /// Task WaitAll 方法
        /// </summary>
        public void TaskTowWaitAll()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Task 1 Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 1 Finish");
            });
            var task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 Begin");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Task 2 Finish");
            });

            task1.Start();
            task2.Start();
            Task.WaitAll(task1, task2);
            Console.WriteLine("All task finished!");

        }
        /// <summary>
        /// Task WaitAny 方法
        /// </summary>
        public void TaskTowWaitAnyAll()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Task 1 Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 1 Finish");
            });
            var task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 Begin");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Task 2 Finish");
            });

            task1.Start();
            task2.Start();
            Task.WaitAny(task1, task2);
            Console.WriteLine("All task finished!");

        }
        /// <summary>
        /// task ContinueWith 属性
        /// </summary>
        public void TaskTowContinueWith()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Task 1 Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 1 Finish");
            });
            var task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 Begin");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Task 2 Finish");
            });


            task1.Start();
            task2.Start();
            var result = task1.ContinueWith<string>(task =>
            {
                Console.WriteLine("task1 finished!");
                return "This is task result!";
            });

            Console.WriteLine(result.Result.ToString());

            //与下相同
            //var SendFeedBackTask = Task.Factory.StartNew(() => { Console.WriteLine("Get some Data!"); })
            //                .ContinueWith<bool>(s => { return true; })
            //                .ContinueWith<string>(r =>
            //                {
            //                    if (r.Result)
            //                    {
            //                        return "Finished";
            //                    }
            //                    else
            //                    {
            //                        return "Error";
            //                    }
            //                });
            //Console.WriteLine(SendFeedBackTask.Result);

            //Task.Factory.StartNew<string>(() => { return "One"; }).ContinueWith(ss => { Console.WriteLine(ss.Result); });
        }

        /// <summary>
        /// 取消Task
        /// </summary>
        public void TaskCancel()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var task = Task.Factory.StartNew(() =>
            {
                for (var i = 0; i < 1000; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Abort mission success!");
                        return;
                    }
                }
            }, token);
            token.Register(() =>
            {
                Console.WriteLine("Canceled");
            });
            Console.WriteLine("Press enter to cancel task...");
            Console.ReadKey();
            tokenSource.Cancel();
            Console.ReadKey();//这句忘了加，程序退出了，看不到“Abort mission success!“这个提示
        }

        /// <summary>
        /// Task嵌套问题
        /// </summary>
        public void TaskQT()
        {
            //嵌套
            var pTask = Task.Factory.StartNew(() =>
            {
                var cTask = Task.Factory.StartNew(() =>
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Childen task finished!");
                });
                Console.WriteLine("Parent task finished!");
            });
            pTask.Wait();
            Console.WriteLine("Flag");

            //关联嵌套
            var pTask1 = Task.Factory.StartNew(() =>
            {
                var cTask = Task.Factory.StartNew(() =>
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Childen task finished!");
                }, TaskCreationOptions.AttachedToParent);//参数增加父Task的
                Console.WriteLine("Parent task finished!");
            });
            pTask1.Wait();
            Console.WriteLine("Flag");
        }

        /// <summary>
        /// 多Task直接调用
        /// </summary>
        public void TaskMuitile()
        {
            Task.Factory.StartNew(() =>
            {
                var t1 = Task.Factory.StartNew<int>(() =>
                {
                    Console.WriteLine("Task 1 running...");
                    return 1;
                });
                t1.Wait(); //等待任务一完成
                var t3 = Task.Factory.StartNew<int>(() =>
                {
                    Console.WriteLine("Task 3 running...");
                    return t1.Result + 3;
                });
                var t4 = Task.Factory.StartNew<int>(() =>
                {
                    Console.WriteLine("Task 2 running...");
                    return t1.Result + 2;
                }).ContinueWith<int>(task =>
                {
                    Console.WriteLine("Task 4 running...");
                    return task.Result + 4;
                });
                Task.WaitAll(t3, t4);  //等待任务三和任务四完成
                var result = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Task Finished! The result is {0}", t3.Result + t4.Result);
                });
            });
            Console.Read();
        }
        /// <summary>
        /// 异常接收
        /// </summary>
        public void TryTask()
        {
            try
            {
                var pTask = Task.Factory.StartNew(() =>
                {
                    var cTask = Task.Factory.StartNew(() =>
                    {
                        System.Threading.Thread.Sleep(2000);
                        throw new Exception("cTask Error!");
                        Console.WriteLine("Childen task finished!");
                    });
                    throw new Exception("pTask Error!");
                    Console.WriteLine("Parent task finished!");
                });

                pTask.Wait();
            }
            catch (AggregateException ex)
            {
                foreach (Exception inner in ex.InnerExceptions)
                {
                    Console.WriteLine(inner.Message);
                }
            }
            Console.WriteLine("Flag");
            Console.Read();
        }
        
        /// <summary>
        /// Task锁 等待5秒
        /// </summary>
        public void TaskLock()
        {
            Task[] tasks = new Task[2];
            tasks[0] = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Task 1 Start running...");
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                }
                Console.WriteLine("Task 1 Finished!");
            });
            tasks[1] = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Task 2 Start running...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 2 Finished!");
            });

            Task.WaitAll(tasks, 5000);
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Status != TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("Task {0} Error!", i + 1);
                }
            }
            Console.Read();

        }

        public void TaskSpinLock()
        {
            SpinLock slock = new SpinLock(false);
            long sum1 = 0;
            long sum2 = 0;
            Parallel.For(0, 100000, i =>
            {
                sum1 += i;
            });

            Parallel.For(0, 100000, i =>
            {
                bool lockTaken = false;
                try
                {
                    slock.Enter(ref lockTaken);
                    sum2 += i;
                }
                finally
                {
                    if (lockTaken)
                        slock.Exit(false);
                }
            });

            Console.WriteLine("Num1的值为:{0}", sum1);
            Console.WriteLine("Num2的值为:{0}", sum2);

            Console.Read();
        }
    }
}
