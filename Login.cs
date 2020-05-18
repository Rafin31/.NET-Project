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
    public partial class Login : Form
    {
       
        public string connString = "Data Source=LAPTOP-HNGUI59P;Initial Catalog=msdb;Integrated Security=True ";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainPage f = new MainPage();
            f.Show();


        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) 
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                if(username== string.Empty || password == string.Empty)
                    MessageBox.Show("Username or Password can not be empty.");
                
                
                String sql = "SELECT* FROM Login_Info WHERE Username = '"+username+"' AND Password = '"+password+"'";
                SqlCommand sq = new SqlCommand(sql,con);
                SqlDataAdapter sda = new SqlDataAdapter(sq);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                String s = "SELECT* FROM User_Info WHERE User_Name = '" + username + "'";
                SqlCommand aa = new SqlCommand(s, con);
                SqlDataAdapter sd = new SqlDataAdapter(aa);
                DataTable d = new DataTable();
                sd.Fill(d);
                string customer_id = d.Rows[0][0].ToString();





                if (dt.Rows.Count > 0)
                {
                    String userRole;
                    userRole = dt.Rows[0][2].ToString();


                    if (userRole == "Customer")
                    {
                        user_interface us = new user_interface(customer_id);
                        this.Hide();
                        us.Show();
                        con.Close();

                    }
                    else
                    {
                        Admin a = new Admin();
                        this.Hide();
                        a.Show();
                        con.Close();
                    }

                    


                }
                else
                    MessageBox.Show("Username or Password incorrect.");
                con.Close();


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
