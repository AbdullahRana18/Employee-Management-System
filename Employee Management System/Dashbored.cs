using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Dashbored : Form
    {
        public Dashbored()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cheack = MessageBox.Show("Are You Sure You Want to LogOut","Confirmation Message",MessageBoxButtons
                .YesNo,MessageBoxIcon.Question);
            if (cheack == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPLOYEE e1 = new EMPLOYEE();
            e1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardui d = new dashboardui();
            d.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SEARCH s = new SEARCH();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salary s1 = new salary();
            s1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lgreg l = new lgreg();
            l.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dashbored_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
