using System;
using System.Threading;
class Printer
{
    public void PrintNumbers()
    {
        //lock (this)
        //{
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(100);
            Console.Write(i + ",");
        }
        Console.WriteLine();
        //}
    }
    public static void print()
    {
        Console.WriteLine("======MultiThreads======");
        Printer p = new Printer();
        Thread[] Threads = new Thread[3];
        for (int i = 0; i < 3; i++)
        {
            Threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
            Threads[i].Name = "threadFilha " + i;
            Console.WriteLine("Thread: " + Threads[i].Name + " iniciada");
        }

        foreach (Thread t in Threads)
        {
            t.Start();
        }


        Console.ReadLine();
    }
}