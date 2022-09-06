using System.Windows;

namespace WpfAppDemo1
{
    /// <summary>
    /// Interaction logic for SimpleCalc.xaml
    /// </summary>
    public partial class SimpleCalc : Window
    {
        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int fno = int.Parse(textBox.Text);
            int sno = int.Parse(textBox1.Text);
            int sum = fno + sno;
            MessageBox.Show($"The sum of {fno} and {sno} is {sum}");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int fno = int.Parse(textBox.Text);
            int sno = int.Parse(textBox1.Text);
            int mul = fno * sno;
            MessageBox.Show($"The product of {fno} and {sno} is {mul}");
        }
    }
}
