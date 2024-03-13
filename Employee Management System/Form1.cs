using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void username_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (username_showpass.Checked)
            {
                username_password.PasswordChar = '\0';
            }
            else
            {
                username_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
         
           //string login = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";


           // OleDbConnection conn = new OleDbConnection(login);
           // conn.Open();
           // string login1;
           // login1 = "select * from Login where UserName ='" + username_input.Text + "' and PassWord = '" + username_password.Text + "'";
           // OleDbCommand cmd = new OleDbCommand(login1, conn);
           // OleDbDataReader reader = cmd.ExecuteReader();

            
           //     if (reader.Read())
           //     {
           //     MessageBox.Show("Admin Login Successful");
           //     Dashbored d1 = new Dashbored();
           //     d1.Show();
           //     this.Hide();
               
           //     }
           //     else
           //     {
           //         MessageBox.Show("Invalid UserName or PassWord");
           //     }

            
           // conn.Close();
           login l1 = new login();
            l1.CONLOGIN();
            l1.LG(username_input, username_password, this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userreg u = new userreg();
            u.Show();
            this.Hide();
        }
    }
}
