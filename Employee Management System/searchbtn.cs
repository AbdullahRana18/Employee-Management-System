using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Employee_Management_System
{
    internal class searchbtn
    {
        public string search;
        public OleDbConnection conn;
        public OleDbCommand cmd;

        public void CONNADD()
        {
            string ADD = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            conn = new OleDbConnection(ADD);
            conn.Open();

        }
        public void LG(TextBox textBox1,TextBox c,TextBox textBox2, Form currentForm)
        {
            search = "select * from [EMPLOYEE] where [EMPID]=@EmpID";
            cmd = new OleDbCommand(search, conn);
            cmd.Parameters.AddWithValue("@EmpID", textBox1.Text);
            OleDbDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                c.Text = reader.GetString(reader.GetOrdinal("ENAME"));
                //textBox2.Text= reader.GetString(reader.GetOrdinal("EMAIL"));
                textBox2.Text= reader.GetString(reader.GetOrdinal("STATUS"));

            }
            else
            {
                MessageBox.Show("ID NOT FOUND");
            }
        }
    }
}
