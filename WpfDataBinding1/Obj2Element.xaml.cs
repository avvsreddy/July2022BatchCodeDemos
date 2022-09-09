using System.Windows;
using WpfDataBinding1.Entities;

namespace WpfDataBinding1
{
    /// <summary>
    /// Interaction logic for Obj2Element.xaml
    /// </summary>
    public partial class Obj2Element : Window
    {
        public Obj2Element()
        {
            InitializeComponent();

            Person p = new Person { FirstName = "Sachin", MiddleName = "Ramesh", LastName = "Tendulkar", Age = 45, Location = "Mumbai", Photo = "Images/sachin.gif" };
            this.DataContext = p;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Person person = (Person)this.DataContext;
            MessageBox.Show($"{person.FirstName} {person.MiddleName} {person.LastName}");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Person person = (Person)this.DataContext;
            person.FirstName = "Mahendra";
            person.MiddleName = "Singh";
            person.LastName = "Dhoni";
        }
    }
}
