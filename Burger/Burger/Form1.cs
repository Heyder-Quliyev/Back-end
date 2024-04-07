namespace Burger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            mySecondCostumers1.BringToFront();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //panel4.Height = button7.Height;
            //panel4.Top = button7.Top;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            firstCustomerControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            firstCustomerControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            mySecondCostumers1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //panel4.Height = button4.Height;
            //panel4.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //panel4.Height = button5.Height;
            //panel4.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //panel4.Height = button6.Height;
            //panel4.Top = button6.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panel4.Height = button3.Height;
            //panel4.Top = button3.Top;
        }
    }
}
