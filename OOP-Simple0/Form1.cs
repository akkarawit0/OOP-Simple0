namespace OOP_Simple0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                _Name = textBox_Name.Text,
                _ID = textBox_ID.Text,
                _Yeay = int.Parse(textBox_Yeay.Text),
                _Hight = double.Parse(textBox_Hight.Text),
                _Grade = double.Parse(textBox_Grade.Text),
                _Major = textBox_Major.Text
            };
            student.AddData(this.e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.e.Rows.Clear();
        }
    }
}