using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Employee_Management_System
{
    internal class fatchdata
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
        public void LG(TextBox textBox1, TextBox c, TextBox textBox2,TextBox textBox7,TextBox textBox6,TextBox textBox3,TextBox textBox4,TextBox textBox5, Form currentForm)
        {
            search = "select * from [EMPLOYEE] where [EMPID]=@EmpID";
            cmd = new OleDbCommand(search, conn);
            cmd.Parameters.AddWithValue("@EmpID", textBox1.Text);
            OleDbDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                c.Text = reader.GetString(reader.GetOrdinal("EMAIL"));
                textBox2.Text = reader.GetString(reader.GetOrdinal("ENAME"));
                textBox7.Text = reader.GetString(reader.GetOrdinal("EDU"));
                textBox6.Text = reader.GetString(reader.GetOrdinal("STATUS"));
                textBox3.Text = reader.GetString(reader.GetOrdinal("GENDER"));
                textBox4.Text = reader.GetInt32(reader.GetOrdinal("PNUM")).ToString();
                textBox5.Text = reader.GetInt32(reader.GetOrdinal("SALARY")).ToString();
            }
            else
            {
                MessageBox.Show("ID NOT FOUND");
            }


        }


    }
}
