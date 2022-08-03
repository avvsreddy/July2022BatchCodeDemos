using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //p.Id = 100;
            Person p = new Person { Id = 111 };
            p.Name = "abc";
            //p.Id = 222;
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Name);
        }
    }
    class Person
    {
        public int Id { get; init; }
        public string Name { get; set; }

        //public Person(int id)
        //{
        //    Id = id;
        //}
    }
}
