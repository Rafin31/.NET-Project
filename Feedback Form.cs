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
    public partial class Feedback_Form : Form
    {
        string customer_id;
        public string connString = "Data Source=LAPTOP-HNGUI59P;Initial Catalog=msdb;Integrated Security=True ";
        public Feedback_Form(string id)
        {
            this.customer_id = id;     
            InitializeComponent();
        }

        private void Feedback_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     



        private void Feedback_Form_Load(object sender, EventArgs e) { }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);

            string name = textBox1.Text;
            String feedback = textBox2.Text;

            if(name == string.Empty || feedback ==string.Empty )
            {
                MessageBox.Show("Fillup All The Box ");
            }
            else 
            {

                con.Open();
                String sql = "INSERT INTO FeedBack_Table1 (Name,FeedBack) VALUES('" + name + "', '" + feedback + "')";
                SqlDataAdapter adt = new SqlDataAdapter(sql, con);
                adt.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Thank you for your Feedback ");
                textBox1.Clear();
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_interface u = new user_interface(customer_id);
            u.Show();
            this.Hide();
        }
    }
}
