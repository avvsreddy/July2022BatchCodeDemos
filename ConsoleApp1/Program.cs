namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.B1();
        }
    }

    public class A
    {
        public void A1() { }
        public void A2() { }
    }

    public class B
    {
        private A a = new A();
        public void B1() { a.A1(); }
        public void B2() { a.A2(); }
    }
}


