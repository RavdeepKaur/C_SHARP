namespace day7
{
    public partial class Form1 : Form
    {
        Form2 secondform;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secondform=new Form2(textBox1.Text,textBox2.Text);
            secondform.ShowDialog();
        }
    }
}