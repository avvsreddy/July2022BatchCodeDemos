

// Direct method call


namespace DelegatesDemo1
{
    // Step 1: declare the delegate
    delegate void MyDelegate(string str);
    //class MyDelegate : MulticastDelegate
    //{

    //}

    public class Program
    {
        public static void Main()
        {
            // Step 2: Instatiate and Initialize
            MyDelegate d1 = new MyDelegate(Greeting);
            Program p1 = new Program();
            d1 += p1.Hello; // Subscribe
            d1 -= Greeting; // Unsubscribe

            // Step 3: Invoke

            // direct call
            //Greeting("direct call");
            // 1. indirect call 
            //d1.Invoke("indirect call 1");
            // 2. indirect call
            d1("indirect call 2");

        }

        static void Greeting(string msg)
        {
            Console.WriteLine($"Greeting: {msg}");
        }

        void Hello(string str)
        {
            Console.WriteLine($"Hello: {str}");
        }
    }


}

