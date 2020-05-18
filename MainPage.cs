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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Visible = false;
            r.Show();

        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PLease Login First","PLease",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PLease Login First", "PLease", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PLease Login First", "PLease", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
