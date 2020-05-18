using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tour_Booking_System
{
    public partial class cart : Form
    {
        public String customer_id;
        public string connString = "Data Source=LAPTOP-HNGUI59P;Initial Catalog=msdb;Integrated Security=True ";
        
        public cart(string id)
        {
            this.customer_id = id;
            InitializeComponent();
        }

        private void cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_interface u = new user_interface(customer_id);
            u.Show();

        }

        private void cart_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            String s = "SELECT* FROM BOOKINGS_TABLE WHERE CUSTOMER_ID = '" + this.customer_id + "'";
            SqlCommand aa = new SqlCommand(s, con);
            SqlDataAdapter sd = new SqlDataAdapter(aa);
            DataTable d = new DataTable();
            sd.Fill(d);
           
            dataGridView1.DataSource = d;

            
        }

       
    }
}
