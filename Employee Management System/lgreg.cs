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
    public partial class lgreg : Form
    {
        public lgreg()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string eid = username_input.Text;
            string password = username_password.Text;
            string EMPID = textBox1.Text;
            portalinfo p = new portalinfo();
            p.CONNADD(eid,password,EMPID);
            if (eid == "" || password == "" ||EMPID == "")
            {
                MessageBox.Show("Please Enter Full Data");
            }
            else
            {
                p.data(eid,password, EMPID);
                MessageBox.Show("Data Added Successfully");
            } 



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbored d1 = new Dashbored();
            d1.Show();
            this.Hide();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
