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
  
    public partial class Admin : Form
    {
        
        public Admin()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            MainPage m = new MainPage();
            m.Show();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Employee am = new Add_Employee();
            this.Hide();
            am.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkFeedback c = new checkFeedback();
            this.Hide();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Product_Upload p = new Product_Upload();
            p.Show();
            this.Visible = false;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bookings b = new Bookings();
            this.Hide();
            b.Show();


        }
    }
}
