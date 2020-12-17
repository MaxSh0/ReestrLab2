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
    public partial class Form1 : Form
    {
        public string numberCard;

        FormServer fs = (FormServer)Application.OpenForms["FormServer"];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string money = "";
            fs.textLog.Text += "Напечатана выписка и карта: " + numberCard + " возвращена владельцу, время: " + DateTime.Now.ToString() + "\r\n";
            Check ch = new Check();
            for (int i = 0; i < fs.dataGridView1.RowCount - 1; i++)
            {
               if(fs.dataGridView1.Rows[i].Cells[0].Value.ToString() == numberCard) 
                {
                    money = fs.dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
            }
            ch.textBox1.Text ="На вашем счету:" + money + "\r\n Спасибо что используете MaxBank";
            ch.Show();


            СardСontrollerForm f = new СardСontrollerForm();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fs.textLog.Text += "Карта: " + numberCard + " возвращена владельцу, время: " + DateTime.Now.ToString()+ "\r\n";
            СardСontrollerForm f = new СardСontrollerForm();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMoney mf = new AddMoney(numberCard, check.Checked);
            mf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            withdrawMoney wm = new withdrawMoney(numberCard, check.Checked);
            wm.ShowDialog();
        }
    }
}
