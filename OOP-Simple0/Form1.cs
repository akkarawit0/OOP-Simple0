namespace OOP_Simple0
{
    public partial class Form1 : Form
    {
        List<string> NameOfStudents = new List<string>();
        List<double> Grades = new();
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
            NameOfStudents.Add(student._Name);
            Grades.Add(student._Grade);

            Grades.Sort();

            min.Text = "คะแนนต่ำสุดคือ " + Grades.First().ToString();
            top.Text = "คะแนนสูงสุดคือ " + Grades.Last().ToString();

            all.Text = "นักเรียนทั้งหมด "+NameOfStudents.Count.ToString() + " คน";
            ee.Rows.Add(student._Name, student._ID, student._Yeay, student._Hight, student._Grade, student._Major);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ee.Rows.Clear();
        }
    }
}