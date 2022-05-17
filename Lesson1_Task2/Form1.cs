namespace Lesson1_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //818, 497
            button1.Location = new Point(new Random().Next(0, 750), new Random().Next(0, 400));
        }
    }
}