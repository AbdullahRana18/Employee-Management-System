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
    public partial class userreg : Form
    {
        public userreg()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            reguser l = new reguser();
            l.CONLOGIN();

            l.LG(username_input, username_password, textBox1, this);
            //userdashboard u = new userdashboard();
            //u.Show();
            //this.Hide();

        }

        private void login_acnt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
