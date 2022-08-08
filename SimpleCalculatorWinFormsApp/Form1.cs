using SimpleMathLibrary;
namespace SimpleCalculatorWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int fno = int.Parse(textBox1.Text);
                int sno = int.Parse(textBox2.Text);
                SimpleMath sm = new SimpleMath();
                int sum = sm.Sum(fno, sno);
                MessageBox.Show($"The sum of {fno} and {sno} is {sum}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter only numbers");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Enter small numbers only");
            }
            catch (InvalidEvenNumberException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}