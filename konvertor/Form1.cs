using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int imeem = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                if (radioButton5.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem);
                }
                if (radioButton6.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem / 72);
                }
                if (radioButton7.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem / 82);
                }
                if (radioButton8.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem / 98);
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton5.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem * 72);
                }
                if (radioButton6.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem);
                }
                if (radioButton7.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem * 0.8);
                }
                if (radioButton8.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem / 0.7);
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton5.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem * 82);
                }
                if (radioButton6.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem * 1.1);
                }
                if (radioButton7.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem);
                }
                if (radioButton8.Checked)
                {
                    textBox2.Text = Convert.ToString(imeem / 0.8);
                }
                if (radioButton4.Checked)
                {
                    if (radioButton5.Checked)
                    {
                        textBox2.Text = Convert.ToString(imeem * 98);
                    }
                    if (radioButton6.Checked)
                    {
                        textBox2.Text = Convert.ToString(imeem * 1.3);
                    }
                    if (radioButton7.Checked)
                    {
                        textBox2.Text = Convert.ToString(imeem * 1.2);
                    }
                    if (radioButton8.Checked)
                    {
                        textBox2.Text = Convert.ToString(imeem);
                    }
                }
            }
        }
    }
}
