using System;
using System.Threading;

namespace Lectia12_ParalelSiAsincron
{
    class Program
    {
        public async void Run()
        {
            Method1();
            Method2();
            Method3();

            Thread t1 = new Thread(Method1);
            t1.Name = "T1";
            Thread t2 = new Thread(Method2);
            t2.Name = "T2";
            Thread t3 = new Thread(Method3);
            t3.Name = "T3";

            t1.Start();
            t2.Start();
            t3.Start();

        }

        public void Method1()
        {
            Console.WriteLine("-----Method1 starts-----");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Method 1 " + i);
            }
            Console.WriteLine("-----Method1 ends-----");
        }
        public void Method2()
        {
            Console.WriteLine("-----Method2 starts-----");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Method 2 " + i);

                if(i==20)
                {
                    Console.WriteLine("Thread " + Thread.CurrentThread.Name + " is going to sleep");
                    Thread.Sleep(3000);
                    Console.WriteLine("Thread " + Thread.CurrentThread.Name + " woke up");
                }
            }
            Console.WriteLine("-----Method2 ends-----");
        }
        public void Method3()
        {
            Console.WriteLine("-----Method3 starts-----");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Method 3 " + i);
            }
            Console.WriteLine("-----Method3 ends-----");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
    }
}
