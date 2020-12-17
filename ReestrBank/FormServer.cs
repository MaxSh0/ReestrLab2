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
    public partial class FormServer : Form
    {
        
        public FormServer()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("123", "1234","1000");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCard_Click(object sender, EventArgs e)
        {
            bool unique = true;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == numericUpDown1.Value.ToString())
                {
                    unique = false;
                }
            }

            if ( unique)
            {
                dataGridView1.Rows.Add(numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString(), "0");
                return;
            }
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            СardСontrollerForm fcc = new СardСontrollerForm();
            fcc.Show();
        }


    }
}
