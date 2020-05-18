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
    
    public partial class user_interface : Form
    {
        string customer_id;
        public string connString = "Data Source=LAPTOP-HNGUI59P;Initial Catalog=msdb;Integrated Security=True ";
        public user_interface( string a)
        {
            this.customer_id = a;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Login l = new Login();
            l.Show();
            this.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feedback_Form f = new Feedback_Form(customer_id);
            f.Show();
            this.Hide();

        }

        private void user_interface_Load(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            order_confirmation o = new order_confirmation(1000,customer_id);
            o.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            order_confirmation o = new order_confirmation(1001,customer_id);
            o.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            order_confirmation o = new order_confirmation(1002,customer_id);
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cart c = new cart(customer_id);
            c.Show();
            
        }
    }
}
