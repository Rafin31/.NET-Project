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
    public partial class checkFeedback : Form
    {
        public checkFeedback()
        {
            InitializeComponent();
        }

        private void checkFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'msdbDataSet1.FeedBack_Table1' table. You can move, or remove it, as needed.
            this.feedBack_Table1TableAdapter.Fill(this.msdbDataSet1.FeedBack_Table1);
            // TODO: This line of code loads data into the 'msdbDataSet.FeedBack_Table' table. You can move, or remove it, as needed.
         

        }

        private void checkFeedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }
    }
}
