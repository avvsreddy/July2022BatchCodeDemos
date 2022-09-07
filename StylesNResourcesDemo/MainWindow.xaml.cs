using System;
using System.Windows;

namespace StylesNResourcesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double d = 10.5;
            Double d1 = new Double();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            w2.ShowDialog();
        }
    }
}
