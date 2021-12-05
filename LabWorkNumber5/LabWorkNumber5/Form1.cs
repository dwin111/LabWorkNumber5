namespace LabWorkNumber5
{
    public partial class Form1 : Form
    {
        private List<PhoneDirectory> _phoneDirectory = new List<PhoneDirectory>();
        private List<Person> _person = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _phoneDirectory.Add(new Person(textBox1.Text, textBox2.Text, textBox3.Text));
            _person.Add(new Person(textBox1.Text, textBox2.Text, textBox3.Text));
            comboBox4.Items.Add(textBox1.Text);
            FillingListBox();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _phoneDirectory.Add(new Organization(textBox6.Text, textBox5.Text, textBox4.Text, textBox10.Text, _person[Convert.ToInt32(comboBox4.SelectedIndex)]));
            FillingListBox();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            _phoneDirectory.Add(new Friend(textBox9.Text, textBox7.Text, textBox8.Text, dateTimePicker1.Text));
            FillingListBox();
        }
        private void FillingListBox()
        {
            listBox1.Items.Clear();
            foreach(var item in _phoneDirectory)
            {
                listBox1.Items.Add(item.InformationOuntput());
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                listBox1.Items.Clear();
                foreach (var item in _person)
                {
                    if (item.CheckingForAMatch(textBox12.Text.ToLower()))
                    {
                        listBox1.Items.Add(item.InformationOuntput());
                    }
                }
            }
            else
            {
                FillingListBox();
            }
        }
    }
}