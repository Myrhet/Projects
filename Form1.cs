using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._11._2021_Tri_mashiny
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.ImageLocation = "https://s0.rbk.ru/v6_top_pics/resized/1440xH/media/img/3/38/755072760499383.jpg";
                label4.Text = "Lada Piora";
                label5.Text = "Цена выбранного автомобиля - 200 000 руб.";
            }

            if (radioButton2.Checked)
            {
                pictureBox1.ImageLocation = "https://auto.ironhorse.ru/wp-content/uploads/2017/01/Mondeo-Mk5-tmb-550x300.jpg";
                label4.Text = "Ford Mondeo";
                label5.Text = "Цена выбранного автомобиля - 2 500 000 руб.";
            }

            if (radioButton3.Checked)
            {
                pictureBox1.ImageLocation = "https://www.zr.ru/d/story/58/909912/bugatti-chiron-2017-1600-17.jpg";
                label4.Text = "Bugatti Chiron";
                label5.Text = "Цена выбранного автомобиля - У тебя нет столько денег.";
            }
        }
    }
}
