namespace MTConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigData bigData = new BigData();
            //bigData.Fill();
            //bigData.Fill();
            Parallel.Invoke(bigData.Fill, bigData.Fill);
            Console.WriteLine($"Count: {bigData.data.Count}");
        }
    }
    class BigData
    {
        public Stack<int> data = new Stack<int>();
        public void Fill()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                data.Push(i);
            }
        }
    }
}