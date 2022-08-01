// See https://aka.ms/new-console-template for more information
namespace Test
{
    class Program : Object
    {
        public static void Main()
        {
            Person p = new Person();
            p.age = 200;
            //p.SetAge(200);
            //int a = p.GetAge();
            p.Age = 20;
            int a = p.Age;
        }

    }
    public class Person : Object
    {
        // Members

        // fields
        private int personId;
        private string personName;
        private string MobileNumber;
        


        // public - 5
        // private - 1
        // protected - 4
        // internal -3
        // protected internal - 2


        // methods
       private int age;
        public int Age
        {
            get{
                return age;
            }
            set
            {
                if (value > 100)
                {
                    age = 1;
                }
                age = value;
            }
        }

        //public int GetAge()
        //{
        //    return age;
        //}

        //public  void SetAge(int a)
        //{
        //    if(a > 100)
        //    {
        //        age = 1;
        //    }
        //    age = a;
        //}
        // constructors
        // desctructors

        // properties
        // indexers
        // events

    }
}