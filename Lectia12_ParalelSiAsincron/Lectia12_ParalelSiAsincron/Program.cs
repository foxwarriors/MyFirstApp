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

        public void TestThreads()
        {
            Thread ping = new Thread(Ping);
            Thread pong = new Thread(Pong);
            ping.Name = " a";
            ping.Priority = ThreadPriority.AboveNormal;
            pong.Name = " b";
            ping.Start();
            ping.Join();
            pong.Start();
        }

        private void Pong()
        {
            int x = 0;
            while (true)
            {
                Console.WriteLine(x + " Pong" +  Thread.CurrentThread.Name + " " +Thread.CurrentThread.ThreadState + " " +Thread.CurrentThread.Priority);
                Thread.Sleep(1000);

                x++;
                if (x == 20)
                {
#pragma warning disable SYSLIB0006 // Type or member is obsolete
                    Thread.CurrentThread.Abort();
#pragma warning restore SYSLIB0006 // Type or member is obsolete
                }
            }
        }

        private void Ping()
        {
            int x = 0;
            while (true)
            {
                Console.WriteLine(x + " Ping" + Thread.CurrentThread.Name + " " + Thread.CurrentThread.ThreadState + " " + Thread.CurrentThread.Priority);
                Thread.Sleep(1000);

                x++;
                if (x == 20)
                {
#pragma warning disable SYSLIB0006 // Type or member is obsolete
                    Thread.CurrentThread.Abort();
#pragma warning restore SYSLIB0006 // Type or member is obsolete
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Run();
            p.TestThreads();
        }
    }
}
