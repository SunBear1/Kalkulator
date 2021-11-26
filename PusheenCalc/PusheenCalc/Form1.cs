using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PusheenCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pierwsza,druga;
        char action = ' ';
        private void dzialanie(int liczba)
        {
            if (action == ' ')
            {
                pierwsza += liczba;
                textBox1.Text = pierwsza;
            }
            else
            {
                druga += liczba;
                textBox1.Text = druga;
            }
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            dzialanie(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dzialanie(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dzialanie(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dzialanie(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dzialanie(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dzialanie(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dzialanie(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dzialanie(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dzialanie(9);
        }
        private void button0_Click(object sender, EventArgs e)
        {
            dzialanie(0);
        }
        private void buttondodaj_Click(object sender, EventArgs e)
        {
           action = '+';
           textBox1.Text = "";
        }

        private void buttonodejmij_Click(object sender, EventArgs e)
        {
            action = '-';
            textBox1.Text = "";
        }

        private void buttonpomnoz_Click(object sender, EventArgs e)
        {
            action = '×';
            textBox1.Text = "";
        }

        private void buttonpodziel_Click(object sender, EventArgs e)
        {
            action = '÷';
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonexe_Click(object sender, EventArgs e)
        {
            switch(action)
            {
                case ('+'):
                    textBox1.Text = (int.Parse(pierwsza) + int.Parse(druga)).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (int.Parse(pierwsza) - int.Parse(druga)).ToString();
                    break;
                case ('×'):
                    textBox1.Text = (int.Parse(pierwsza) * int.Parse(druga)).ToString();
                    break;
                case ('÷'):
                    if (druga == "0")
                    {
                        MessageBox.Show("Dzielenie przez zero, błąd");
                        break;
                    }
                      
                    textBox1.Text = (int.Parse(pierwsza) / int.Parse(druga)).ToString();
                    break;
            }
            pierwsza = "";
            druga = "";
            action = ' ';
        }

        private void buttoncl_Click(object sender, EventArgs e)
        {
            pierwsza = "";
            druga = "";
            action = ' ';
            textBox1.Clear();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100007042654741&ref=br_rs");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        

   
    }
