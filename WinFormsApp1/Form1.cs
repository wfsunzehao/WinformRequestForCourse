namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.CourseIdText.Text.Length != 32 || this.SourceIdText.Text.Length != 32)
            {
                MessageBox.Show("请输入完整的CourseId和SourceId");
            }
            else
            {
                if () { }
            }
        }
    }
}
