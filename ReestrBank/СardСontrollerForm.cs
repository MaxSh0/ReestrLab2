using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReestrBank
{
    public partial class СardСontrollerForm : Form
    {
        FormServer fs = (FormServer)Application.OpenForms["FormServer"];
        public СardСontrollerForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '1';
            }
        }


        private bool checkCard() 
        {
            
        for (int i = 0; i<fs.dataGridView1.RowCount-1; i++) 
            {
            if (fs.dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox2.Text) 
                {
                if(fs.dataGridView1.Rows[i].Cells[1].Value.ToString()== textPassword.Text) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            if (checkCard())
            {
                fs.textLog.Text += "Произошел произошел вход с картой: " + textBox2.Text + " пароль: " + textPassword.Text + " время: " + DateTime.Now.ToString() + "\r\n";
                Form1 f = new Form1();
                f.Show();
                f.numberCard = textBox2.Text;
                this.Close();
            }
            else
            {
                labelPincode.Text = "Неверный пароль";
                labelPincode.ForeColor = Color.Red;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '2';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '3';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '4';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '5';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '6';
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '7';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '8';
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '9';
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textPassword.TextLength < 4 && textPassword.Enabled != false)
            {
                textPassword.Text += '0';
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textPassword.Text.Length > 0 && textPassword.Enabled != false)
            {
                textPassword.Text = textPassword.Text.Substring(0, textPassword.Text.Length - 1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Enabled = true;
                textBox2.Enabled = true;
            }
            else 
            {
                label1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0) 
            {
                textPassword.Enabled = true;
                labelPincode.Visible = true;
            }
            else 
            {
                textPassword.Enabled = false;
                labelPincode.Visible = false;
            }
        }
    }
}
