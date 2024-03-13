using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Employee_Management_System
{
    internal class salar
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
        public void LG(string empId, string empName, string status, string s)
        {
            LOGIN = "SELECT * FROM [EMPLOYEE] WHERE [EMPID] = @empId";
            cmd = new OleDbCommand(LOGIN, conn);
            cmd.Parameters.AddWithValue("@empId", empId);
            cmd.Parameters.AddWithValue("@empName", empName);
            cmd.Parameters.AddWithValue("@status", status);

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // Employee exists in the database, proceed to add salary
                string addSalaryQuery = "UPDATE [EMPLOYEE] SET [SALARY] = @s WHERE [EMPID] = @empId";
                cmd = new OleDbCommand(addSalaryQuery, conn);
                cmd.Parameters.AddWithValue("@s", s);
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary added successfully.");
            }
            else
            {
                // Employee does not exist in the database
                MessageBox.Show("Employee not found in the database.");
            }

            reader.Close();
        }
    }
}
