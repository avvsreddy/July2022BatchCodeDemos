using System.Windows;

namespace StylesNResourcesDemo
{
    /// <summary>
    /// Interaction logic for FancyWindow.xaml
    /// </summary>
    public partial class FancyWindow : Window
    {
        public FancyWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fancy Button clicked");
        }
    }
}
