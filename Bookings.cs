using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Booking_System
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
           
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void Bookings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
                
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'msdbDataSet4.BOOKINGS_TABLE' table. You can move, or remove it, as needed.
            this.bOOKINGS_TABLETableAdapter1.Fill(this.msdbDataSet4.BOOKINGS_TABLE);
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
