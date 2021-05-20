using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroupProject32D

{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        int Dollar = 30;
        int Euro = 42;
        int Frank = 60;
        int x;
        int z;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (this.radioButton1.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Dollar * x;
                textBox2.Text = z.ToString();
            }


            else if (this.radioButton2.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Euro * x;
                textBox2.Text = z.ToString();

            }

            else if (this.radioButton3.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Frank * x;
                textBox2.Text = z.ToString();

            }

        }
    }
}