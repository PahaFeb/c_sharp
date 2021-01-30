using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Color cl = new Color();

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void buttonYes_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonNo_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Не корректный ввод");
                
            }
            else
            {
                Form1.x1 = Convert.ToInt32(textBox1.Text);
                Form1.x2 = Convert.ToInt32(textBox4.Text);
                Form1.y1 = Convert.ToInt32(textBox2.Text);
                Form1.y2 = Convert.ToInt32(textBox3.Text);
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                MessageBox.Show("Не выбран цвет");
            else
            {
                Form f = new Form1();
                
                this.Close();
            }
                
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            cl = Color.Red;
            Form1.color = cl;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cl = Color.Green;
            Form1.color = cl;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cl = Color.Blue;
            Form1.color = cl;
        }
    }
}
