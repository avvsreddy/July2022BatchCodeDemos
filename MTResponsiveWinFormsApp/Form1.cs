namespace MTResponsiveWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                // Draw Red Rectangles
                Graphics g = panel1.CreateGraphics();
                Random rnd = new Random();
                for (int i = 1; i <= 1000; i++)
                {
                    int x = rnd.Next(panel1.Height);
                    int y = rnd.Next(panel1.Width);
                    g.DrawRectangle(Pens.Red, x, y, 20, 20);
                    Thread.Sleep(100);
                }
            }).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task t1 = new Task(DrawBlueRectangles);
            t1.Start();

        }

        private void DrawBlueRectangles()
        {
            // Draw Blue Rectangles
            Graphics g = panel2.CreateGraphics();
            Random rnd = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                int x = rnd.Next(panel2.Height);
                int y = rnd.Next(panel2.Width);
                g.DrawRectangle(Pens.Blue, x, y, 20, 20);
                Thread.Sleep(100);
            }
        }
    }
}