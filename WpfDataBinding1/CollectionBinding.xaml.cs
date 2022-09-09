using System.Collections.Generic;
using System.Windows;
using WpfDataBinding1.Entities;

namespace WpfDataBinding1
{
    /// <summary>
    /// Interaction logic for CollectionBinding.xaml
    /// </summary>
    public partial class CollectionBinding : Window
    {
        public CollectionBinding()
        {
            InitializeComponent();

            List<Person> people = new List<Person>
            {
                new Person{FirstName="Sachin", MiddleName="Ramesh",LastName="Tendulkar", Photo="Images/sachin.gif" },
                new Person{FirstName="Mahendra", MiddleName="Singh",LastName="Dhoni" },
                new Person{FirstName="Virat", MiddleName="",LastName="Kholi" },
                new Person{FirstName="Rohith", MiddleName="",LastName="Sharma" },
                new Person{FirstName="Hardik", MiddleName="",LastName="Pandya" },

            };

            this.DataContext = people;


        }
    }
}
