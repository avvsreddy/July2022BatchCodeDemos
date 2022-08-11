// See https://aka.ms/new-console-template for more information


using System.Diagnostics;

Console.WriteLine("Running Seq.....");
Stopwatch w = Stopwatch.StartNew();
M1();
M2();
Console.WriteLine(w.ElapsedMilliseconds);
w = Stopwatch.StartNew();
Console.WriteLine("Running using multi threading");

ThreadStart ts1 = new ThreadStart(M1);
Thread t1 = new Thread(ts1);
t1.Start();

Thread t2 = new Thread(M2);
t2.Start();

t1.Join();
t2.Join();
Console.WriteLine(w.ElapsedMilliseconds);

Console.WriteLine("Running using Task - (TPL)");
w = Stopwatch.StartNew();
Task tt1 = new Task(M1);
tt1.Start();
Task tt2 = new Task(M2);
tt2.Start();

tt1.Wait();
tt2.Wait();
Console.WriteLine(w.ElapsedMilliseconds);

Console.WriteLine("Running using Parallel");
w = Stopwatch.StartNew();
Parallel.Invoke(M1, M2);
Console.WriteLine(w.ElapsedMilliseconds);

w = Stopwatch.StartNew();
Console.WriteLine("Running using Parallel For....");
Parallel.Invoke(M11, M22);
Console.WriteLine(w.ElapsedMilliseconds);

static void M1()
{
    //Console.WriteLine($"M1 running in thread id : {Thread.CurrentThread.ManagedThreadId}");
    for (int i = 1; i <= 10; i++)
    {
        // complex code
        Thread.Sleep(500);
    }
}


static void M2()
{
    //Console.WriteLine($"M2 running in thread id : {Thread.CurrentThread.ManagedThreadId}");
    for (int i = 1; i <= 10; i++)
    {
        // complex code
        Thread.Sleep(500);
    }
}


static void M11()
{
    //Console.WriteLine($"M1 running in thread id : {Thread.CurrentThread.ManagedThreadId}");
    //for (int i = 1; i <= 10; i++)
    Parallel.For(1, 11, i =>
    {
        // complex code
        Thread.Sleep(500);
    });
}


static void M22()
{
    //Console.WriteLine($"M2 running in thread id : {Thread.CurrentThread.ManagedThreadId}");
    //for (int i = 1; i <= 10; i++)
    Parallel.For(1, 11, x =>
    {
        // complex code
        Thread.Sleep(500);
    });
}