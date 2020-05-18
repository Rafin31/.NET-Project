using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Tour_Booking_System
{
    public partial class Product_Upload_Page : UserControl
    {
        public string connString = "Data Source=LAPTOP-HNGUI59P;Initial Catalog=msdb;Integrated Security=True ";
        string imagelocation = "";
        SqlCommand cmd;
        public Product_Upload_Page()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Admin a = new Admin();
            a.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.* ";
            if (d.ShowDialog()== DialogResult.OK) 
            {
                imagelocation = d.FileName.ToString();
                pictureBox1.ImageLocation = imagelocation; 

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);            con.Open();

            byte[] image = null;
            FileStream stream = new FileStream(imagelocation,FileMode.Open,FileAccess.Read);
            BinaryReader b = new BinaryReader(stream);
            image = b.ReadBytes((int)stream.Length);

            string title = textBox1.Text;
            string Description = textBox3.Text;
            string price = textBox4.Text;

            string sql = "Insert into Product_Table (Product_Title,Product_Description,Price,Photo) Values ('" + title + "'," + Description + "'," + price + "',@image) ";
            cmd = new SqlCommand(sql,con);
            cmd.Parameters.Add(new SqlParameter("@image",image));
         
            
            int n =cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(n.ToString() + "Product Uploaded Successfully");

        }
    }
}
