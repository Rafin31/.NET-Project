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
    public partial class order_confirmation : Form
    {
        int s;  
        String customer_id ;
        public string connString = "Data Source=LAPTOP-HNGUI59P;Initial Catalog=msdb;Integrated Security=True ";
        public order_confirmation(int A,string id)
        {
            this.s= A;
            this.customer_id = id;
            
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_interface ui = new user_interface(customer_id);
            ui.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);

            string name = textBox1.Text;
            string start_date = textBox6.Text;
            string end_date = textBox7.Text;
            string phonnumber = textBox2.Text;
            string email = textBox3.Text;
            string nationality = textBox4.Text;
            string Address = textBox5.Text;
            string gender = comboBox1.Text;
            string id = s.ToString();

            if (start_date == string.Empty || name == string.Empty || phonnumber == string.Empty || email == string.Empty || nationality == string.Empty || Address == string.Empty)
            {
                MessageBox.Show("Fill up All the Information");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                comboBox1.ResetText();
            }
            else
            {
                con.Open();
                String sql = "INSERT INTO BOOKINGS_TABLE (CUSTOMER_NAME,CUSTOMER_PHONE_NUMBER,TOUR_CODE,TOUR_START_DATE,TOUR_END_DATE,CUSTOMER_ID) VALUES('" + name + "', '" + phonnumber + "','" + id + "','" + start_date + "','" + end_date + "','" + this.customer_id + "')";
                SqlDataAdapter adt = new SqlDataAdapter(sql, con);
                adt.SelectCommand.ExecuteNonQuery();

               

                MessageBox.Show("Order Confirmed");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                comboBox1.ResetText();
            }







        }

        private void order_confirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
