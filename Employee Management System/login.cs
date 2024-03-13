using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Employee_Management_System
{
    internal class login
    {
        public string LOGIN;
        public OleDbConnection  conn;
        public OleDbCommand cmd;
        
        
        public void CONLOGIN()
        {
            LOGIN = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            conn = new OleDbConnection(LOGIN);
            conn.Open();
        }
        public void LG(TextBox username_input, TextBox username_password ,Form currentForm)
        {
             LOGIN = "select * from Login where UserName ='" + username_input.Text + "' and PassWord = '" + username_password.Text + "'";
            cmd = new OleDbCommand(LOGIN, conn);
            OleDbDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                MessageBox.Show("Admin Login Successful");
                Dashbored d1 = new Dashbored();
                d1.Show();
                currentForm.Hide();

            }
            else
            {
                MessageBox.Show("Invalid UserName or PassWord");
            }


        }

    }
}
