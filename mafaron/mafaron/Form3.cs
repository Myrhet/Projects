using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mafaron
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rost = double.Parse(rostBox.Text);
            double ves = double.Parse(vesBox.Text);
            double voz = double.Parse(textBox1.Text);
            double per = 0;


            if (radioButton1.Checked)
            {
                per = 66 +(13.7 * ves) + (5 * rost) - (6.8 * voz);
                double a = per * 1.2;
                label19.Text = a.ToString("##.##");
                double b = per * 1.375;
                label20.Text = b.ToString("##.##");
                double c = per * 1.55;
                label21.Text = c.ToString("##.##");
                double d = per * 1.725;
                label22.Text = d.ToString("##.##");
                double k = per * 1.9;
                label23.Text = k.ToString("##.##");

            }

            if (radioButton2.Checked)
            {
                per = 66 + (9.6 * ves) + (1.8 * rost) - (4.7 * voz);
                double a = per * 1.2;
                label19.Text = a.ToString("##.##");
                double b = per * 1.375;
                label20.Text = b.ToString("##.##");
                double c = per * 1.55;
                label21.Text = c.ToString("##.##");
                double d = per * 1.725;
                label22.Text = d.ToString("##.##");
                double k = per * 1.9;
                label23.Text = k.ToString("##.##");
            }
            label12.Text = per.ToString("##.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rostBox.Clear();
            vesBox.Clear();
            textBox1.Clear();
        }
    }
}
