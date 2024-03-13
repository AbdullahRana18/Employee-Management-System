using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Employee_Management_System
{
    internal class del
    {
        public string ADD;
        public OleDbConnection conn;
        public OleDbCommand cmnd;

        public void CONNADD()
        {
             ADD = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            
                conn = new OleDbConnection(ADD);
                conn.Open();
            
        }
        public void data (int a)
        {
            string delete = "delete from [EMPLOYEE] where (EMPID)=" + a;
            cmnd = new OleDbCommand(delete,conn);
            int deletet = cmnd.ExecuteNonQuery();
            if (deletet > 0)
            {
                MessageBox.Show("DATA DELETED Successfully");

            }
            else
            {
                MessageBox.Show("No data found with the given ID");
            }
        }
    }
}
