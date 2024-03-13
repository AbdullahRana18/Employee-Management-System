using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Employee_Management_System
{
    internal class reguser
    {
        public string LOGIN;
        public OleDbConnection conn;
        public OleDbCommand cmd;

        public void CONLOGIN()
        {
            LOGIN = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            conn = new OleDbConnection(LOGIN);
            conn.Open();
        }

        public void LG(TextBox username_input, TextBox username_password, TextBox textBox1, Form currentForm)
        {
            LOGIN = "SELECT * FROM emp WHERE UserName = ? AND PassWord = ? AND EMPID = ?";
            cmd = new OleDbCommand(LOGIN, conn);

          
            cmd.Parameters.AddWithValue("username", username_input.Text);
            cmd.Parameters.AddWithValue("password", username_password.Text);
            cmd.Parameters.AddWithValue("empid", textBox1.Text);

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("User Login Successful");
                StaticProps.empiid = textBox1.Text;
               
                portal p1 = new portal();
                p1.Show();
                currentForm.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName, PassWord, or EMPID");
            }
        }
    }
}
