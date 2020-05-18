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
    public partial class Add_Employee : Form
    {
        public string connString = "Data Source=LAPTOP-HNGUI59P;Initial Catalog=msdb;Integrated Security=True ";
        public Add_Employee()
        {
            InitializeComponent();
        }

       

        private void Add_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);

            string password = textBox6.Text;
            string confirmPassword = textBox7.Text;
            string username = textBox1.Text;
            string phonnumber = textBox2.Text;
            string email = textBox3.Text;
            string nationality = textBox4.Text;
            string Address = textBox5.Text;
            string gender = comboBox1.Text;
            string role = "Admin";


            if (password != confirmPassword || username == string.Empty || phonnumber == string.Empty || email == string.Empty || nationality == string.Empty || Address == string.Empty)
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
                String sql = "INSERT INTO User_Info (User_Name,Email,Phone_no,Nationality,Address,Gender,Role) VALUES('" + username + "', '" + email + "', '" + phonnumber + "','" + nationality + "','" + Address + "','" + gender + "','" + role + "')";
                SqlDataAdapter adt = new SqlDataAdapter(sql, con);
                adt.SelectCommand.ExecuteNonQuery();

                String s = "INSERT INTO  Login_Info (Username,Password,Role) VALUES('" + username + "', '" + confirmPassword + "','" + role + "')";
                adt = new SqlDataAdapter(s, con);
                adt.SelectCommand.ExecuteNonQuery();

                MessageBox.Show(" Employee Added ");

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
    
    }
}
