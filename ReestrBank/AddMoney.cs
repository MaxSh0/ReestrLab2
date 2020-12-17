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
    public partial class AddMoney : Form
    {
        string numberCard;
        bool check;
        public AddMoney(string num_card, bool num_check)
        {
            InitializeComponent();
            numberCard = num_card;
            check = num_check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double money = 0;
            FormServer fs = (FormServer)Application.OpenForms["FormServer"];
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            for (int i = 0; i < fs.dataGridView1.RowCount - 1; i++)
            {
                if (fs.dataGridView1.Rows[i].Cells[0].Value.ToString() == numberCard)
                {
                    money = Convert.ToDouble(fs.dataGridView1.Rows[i].Cells[2].Value.ToString()) + Convert.ToDouble(numericUpDown1.Value);
                    fs.dataGridView1.Rows[i].Cells[2].Value = money.ToString();
                }
            }
            fs.textLog.Text += "карта: " + numberCard + " пополнена на " + Convert.ToDouble(numericUpDown1.Value) + " время: " + DateTime.Now.ToString() + "\r\n";
            fs.textLog.Text += "карта: " + numberCard + " была возвращена владельцу, время: " + DateTime.Now.ToString() + "\r\n";


            if (check)
            {
                Check ch = new Check();
                ch.textBox1.Text = "На вашем счету:" + money.ToString() +" счет был пополнен на "+ Convert.ToDouble(numericUpDown1.Value) + "\r\n Спасибо что используете MaxBank";
                ch.Show();
            }
            f1.Close();
            СardСontrollerForm f = new СardСontrollerForm();
            f.Show();
            this.Close();
        }
    }
}
