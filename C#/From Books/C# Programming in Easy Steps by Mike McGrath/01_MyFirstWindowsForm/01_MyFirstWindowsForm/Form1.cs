using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MyFirstWindowsForm
{
    public partial class Form1 : Form
    {
        private int num;
        public void setNum(int num) { this.num = num; }
        public int getNum() { return num; }

        public void rate(int guess,int num)
        {
            if (guess < num)
            {
                label2.Text = "Too Low";
            }
            else if (guess > num)
            {
                label2.Text = "Too Hight!";
            }
            else
            {
                label2.Text = "*** Correct ***";
            }
        }
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            setNum(rnd.Next(1, 21));

            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Fuchsia;
            button1.BackColor = Color.Lime;
            button1.BackColor = Color.Aqua;

            int guess = int.Parse(textBox1.Text);
            rate(guess, getNum());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
