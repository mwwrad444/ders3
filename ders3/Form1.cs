using System;
using System.Windows.Forms;

namespace ders3
{
    public partial class Form1 : Form
    {
        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bakı");
            comboBox1.Items.Add("Gəncə");
            comboBox1.Items.Add("Sumqayıt");
            comboBox1.Items.Add("Şəki");
            comboBox1.Items.Add("Lənkəran");

            comboBox2.Items.Add("Bakı");
            comboBox2.Items.Add("Gəncə");
            comboBox2.Items.Add("Sumqayıt");
            comboBox2.Items.Add("Şəki");
            comboBox2.Items.Add("Lənkəran");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Zəhmət olmasa, şəhərləri seçin!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Eyni şəhərlərə gediş yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                n++;
                listBox1.Items.Add(n.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + " (" + dateTimePicker1.Text + ") " + textBox3.Text + " " + maskedTextBox1.Text + " " + textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa, silmək istədiyiniz bileti seçin!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            string c = b;
            comboBox2.Text = a;
            comboBox1.Text = c;
        }
    }
}
