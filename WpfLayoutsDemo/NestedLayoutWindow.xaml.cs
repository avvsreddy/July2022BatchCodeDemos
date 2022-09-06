using System.Windows;

namespace WpfLayoutsDemo
{
    /// <summary>
    /// Interaction logic for NestedLayoutWindow.xaml
    /// </summary>
    public partial class NestedLayoutWindow : Window
    {
        public NestedLayoutWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // add
            int a = int.Parse(fno.Text);
            int b = int.Parse(second.Text);
            int sum = a + b;
            result.Text = $"The sum of {a} and {b} is {sum}";
            result.FontSize = 14;

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // multiply
            int a = int.Parse(fno.Text);
            int b = int.Parse(second.Text);
            int p = a * b;
            result.Text = $"The product of {a} and {b} is {p}";

        }
    }
}
