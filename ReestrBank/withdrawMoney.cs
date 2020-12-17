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
    public partial class withdrawMoney : Form
    {
        string numberCard;
        bool check;
        public withdrawMoney(string num_card, bool num_check)
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
                    money = Convert.ToDouble(fs.dataGridView1.Rows[i].Cells[2].Value.ToString()) - Convert.ToDouble(numericUpDown1.Value);
                    if (money > 0)
                    {
                        fs.dataGridView1.Rows[i].Cells[2].Value = money.ToString();
                    }
                    else 
                    {
                        label1.Text = "Недостаточно средств для снятия";
                        label1.ForeColor = Color.Red;
                        return;
                    }
                }
            }
            fs.textLog.Text += "С карты: " + numberCard + " сняты наличные в размере " + Convert.ToDouble(numericUpDown1.Value) + "руб, время: " + DateTime.Now.ToString() + "\r\n";
            fs.textLog.Text += "Карта: " + numberCard + " была возвращена владельцу, время: " + DateTime.Now.ToString() + "\r\n";


            if (check)
            {
                Check ch = new Check();
                ch.textBox1.Text = "На вашем счету:" + money.ToString() + " С карты были сняты наличные в размере " + Convert.ToDouble(numericUpDown1.Value) + "\r\n Спасибо что используете MaxBank";
                ch.Show();
            }
            f1.Close();
            СardСontrollerForm f = new СardСontrollerForm();
            f.Show();
            this.Close();
        }
    }
}
