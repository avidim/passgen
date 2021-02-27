using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        uint passLength = 8;
        string[] lwr = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] upr = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] num = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] sym = { "-", "!", "@", "#", "$", "%", "^", "&", "*", "_" };
        Random random = new Random();
        int rnd;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0: label2.Text = "> "; label2.Text += 8;  passLength = 8;  break;
                case 1: label2.Text = "> "; label2.Text += 12; passLength = 12; break;
                case 2: label2.Text = "> "; label2.Text += 16; passLength = 16; break;
                case 3: label2.Text = "> "; label2.Text += 20; passLength = 20; break;
                case 4: label2.Text = "> "; label2.Text += 24; passLength = 24; break;
                case 5: label2.Text = "> "; label2.Text += 28; passLength = 28; break;
                case 6: label2.Text = "> "; label2.Text += 32; passLength = 32; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                MessageBox.Show("Не выбран ни один пункт!", "Ошибка");
                return;
            }
            while (textBox1.TextLength < passLength)
            {
                rnd = random.Next(0, 4);
                switch (rnd)
                {
                    case 0:
                        if (checkBox1.Checked == true)
                        {
                            textBox1.Text += lwr[random.Next(0, lwr.Length)];
                            break;
                        }
                        else
                            continue;
                    case 1:
                        if (checkBox2.Checked == true)
                        {
                            textBox1.Text += upr[random.Next(0, upr.Length)];
                            break;
                        }
                        else
                            continue;
                    case 2:
                        if (checkBox3.Checked == true)
                        {
                            textBox1.Text += num[random.Next(0, num.Length)];
                            break;
                        }
                        else
                            continue;
                    case 3:
                        if (checkBox4.Checked == true)
                        {
                            textBox1.Text += sym[random.Next(0, sym.Length)];
                            break;
                        }
                        else
                            continue;
                }
            }
        }
    }
}