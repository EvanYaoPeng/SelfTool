using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace ThreadTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //Person person = new Person();

            //person.Fly();

            //Console.Read();
            string str = ",1,2,3,";
            string end = str.Trim(',');
            SeleniumUtil.getFileName();
            OutputCallStack();
            Console.ReadLine();
        }

        [System.Diagnostics.Conditional("DEBUG")]
        static public void OutputCallStack()
        {
            System.Diagnostics.Debug.WriteLine(new string('*', 78));
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
            System.Diagnostics.StackFrame[] sfs = st.GetFrames();
            for (int u = 1; u < sfs.Length; ++u)
            {
                System.Reflection.MethodBase mb = sfs[u].GetMethod();
                System.Diagnostics.Debug.WriteLine("[CALL STACK][{0}]: {1} MethodName:{2} ClassName:{3}", u, mb.DeclaringType.FullName, mb.Name, mb.ReflectedType.Name);
            }
        }
    }

    class Person
    {
        public void Fly()
        {
            Fly("test");
        }

        public void Fly(string name)
        {
            Console.WriteLine("我的log日志。\n\n{0}", Environment.StackTrace);
        }
    }
    public class SeleniumUtil
    {
        public static void getFileName()
        {
            StackTrace trace = new StackTrace();
            StackFrame frame = trace.GetFrame(1);
            MethodBase method = frame.GetMethod();
            String className = method.ReflectedType.Name;
            Console.Write("ClassName:" + className + "\nMethodName:" + method.Name);
        }
    }


    //static void Main()
    //{
    //    try
    //    {
    //        string sourcePath = System.Environment.CurrentDirectory + "\\HPS.dll";
    //        String targetPath = System.Environment.CurrentDirectory + "\\Website\\bin\\HPS.dll";
    //        System.IO.File.Copy(sourcePath, targetPath, true);
    //        ////Thread t = new Thread(WriteY);
    //        ////t.Start();                          // Run WriteY on the new thread
    //        ////while (true) Console.Write("x");   // Write 'x' forever
    //        Console.WriteLine("拷贝替换完成！");

    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //    Console.ReadLine();
    //}

    //static void WriteY()
    //{
    //    int flg = 0;
    //    while (flg<50)
    //    {
    //        Console.Write("y");   // Write 'y' forever
    //        flg++;
    //    }
    //}
}
