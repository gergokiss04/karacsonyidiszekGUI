using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karacsonyGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 40; i++)
            {
                comboBox1.Items.Add(i + 1);
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nap = Convert.ToInt32(comboBox1.Text);
            int szam = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text);
            richTextBox1.Text += comboBox1.Text+". nap +"+textBox2.Text+"   -"+textBox1.Text+"  =  "+szam+"\n" ;
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();

            for (int i = nap; i < 40; i++)
            {
                comboBox1.Items.Add(i + 1);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
                button1.Enabled = false;
            }
            else
            {
                label4.Visible = false;
                button1.Enabled = true;
            }

            int szam;
            int szam2;
            bool i = int.TryParse(textBox1.Text,out szam);
            bool j = int.TryParse(textBox2.Text,out szam2);


            if (szam>szam2)
            {
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                button1.Enabled = false;
            }
            else
            {
                label5.Visible = false;
                button1.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
