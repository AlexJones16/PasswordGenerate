using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passw = "1234567890abcdefghijkmnopqrstuwxyz";
            string passWUpper = "1234567890abcdefghijkmnopqrstuwxyzABCDEFGHIJKMNOPQRSTUWXYZ";
            string passWSpecSymbols = "1234567890abcdefghijkmnopqrstuwxyz!@#$%^&*()_+|[]{}?><";
            string passStrongest = "1234567890abcdefghijkmnopqrstuwxyzABCDEFGHIJKMNOPQRSTUWXYZ!@#$%^&*()_+|[]{}?><";
            char[] password = passw.ToCharArray();
            char[] passwordWUpper = passWUpper.ToCharArray();
            Random rn = new Random();
            try
            {
                if (radioButton1.Checked == true)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        richTextBox1.Text += passwordWUpper[rn.Next(passwordWUpper.Length)].ToString();              
                    }
                    richTextBox1.AppendText(Environment.NewLine);
                }
                else if (radioButton2.Checked == true)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        richTextBox1.Text += passWSpecSymbols[rn.Next(passWSpecSymbols.Length)].ToString();
                    }
                    richTextBox1.AppendText(Environment.NewLine);
                }
                else if (radioButton3.Checked == true)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        richTextBox1.Text += passStrongest[rn.Next(passStrongest.Length)].ToString();
                    }
                    richTextBox1.AppendText(Environment.NewLine);
                }
                else
                {
                    for (int i = 0; i < 11; i++)
                    {
                        richTextBox1.Text += password[rn.Next(password.Length)].ToString();
                    }
                    richTextBox1.AppendText(Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
