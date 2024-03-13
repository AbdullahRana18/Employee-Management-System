using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Employee_Management_System
{
    internal class view
    {
        public string VIEW;
        public OleDbConnection conn;
        public OleDbCommand cmnd;

        public void connview()
        {
            VIEW = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            {
                conn = new OleDbConnection(VIEW);
                conn.Open();
            }
        }
        public void data()
        {
            string View1;
            View1 = "select * from [EMPLOYEE]";
        }

    }
}
