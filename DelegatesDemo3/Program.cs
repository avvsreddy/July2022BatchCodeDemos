
using System.Diagnostics;
class Program
{
    public static void Main()
    {
        // client 1
        ProcessManager pMgr = new ProcessManager();
        //pMgr.ShowProcessList(Program.FilterByNone);

        // client 2
        //pMgr.ShowProcessList(Program.FilterByName);

        // client 3
        FilterDelegate f = new FilterDelegate(new Program().FilterBySize);
        pMgr.ShowProcessList(f);

        pMgr.ShowProcessList(new Program().FilterBySize);

        // Anonymous Delegates
        pMgr.ShowProcessList(delegate (Process p)
        {
            return p.WorkingSet64 >= 100 * 1024 * 1024;
        });

        // Lambda : Light Weight Syntax for Anonymous Delegates
        // Lambda Statement

        pMgr.ShowProcessList((Process p) =>
       {
           return p.WorkingSet64 >= 100 * 1024 * 1024;
       });

        // Lambda Expression

        pMgr.ShowProcessList((Process p) =>

             p.WorkingSet64 >= 100 * 1024 * 1024
        );

        // Lambda Expression

        pMgr.ShowProcessList(p => p.WorkingSet64 >= 100 * 1024 * 1024);

        // client 1

        pMgr.ShowProcessList(p => true);

        // client 2

        pMgr.ShowProcessList(x => x.ProcessName.StartsWith("a"));

    }

    // client 1
    public static bool FilterByNone(Process p)
    {
        return true;
    }

    // client 2
    public static bool FilterByName(Process p)
    {
        if (p.ProcessName.StartsWith("s"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // client 3
    public bool FilterBySize(Process p)
    {
        return p.WorkingSet64 >= 100 * 1024 * 1024;
    }
}




public delegate bool FilterDelegate(Process p);
public class ProcessManager
{
    //public void ShowProcessList()
    //{
    //    foreach (Process p in Process.GetProcesses())
    //    {
    //        Console.WriteLine(p.ProcessName);
    //    }
    //}

    public void ShowProcessList(FilterDelegate filter)
    {
        foreach (Process p in Process.GetProcesses())
        {
            //Program prg = new Program();
            if (filter(p))
                Console.WriteLine(p.ProcessName);
        }
    }
    //public void ShowProcessList(long size)
    //{
    //    foreach (Process p in Process.GetProcesses())
    //    {
    //        if (p.WorkingSet64 >= size)
    //        Console.WriteLine(p.ProcessName);
    //    }
    //}
}