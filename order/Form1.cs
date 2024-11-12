namespace order
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string msg = "";
        public static double price = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemform f1 = new itemform();
            f1.ShowDialog();
        }

        private void Mainform_Activated(object sender, EventArgs e)
        {
            textBox1.Text = msg;
        }
    }
}