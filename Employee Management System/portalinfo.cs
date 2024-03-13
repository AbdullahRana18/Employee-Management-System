using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Employee_Management_System
{
    internal class portalinfo
    {

        public OleDbConnection conn;
        public OleDbCommand cmnd;

        public void CONNADD(string eid, string password,string EMPID)
        {
            string ADD = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            {
                conn = new OleDbConnection(ADD);
                conn.Open();
            }
        }
        public void data(string eid, string password,string EMPID)
        {
            string add1 = "INSERT INTO [emp]([UserName],[PassWord],[EMPID]) VALUES (@eid, @password,@EMPID)";
            cmnd = new OleDbCommand(add1, conn);
            cmnd.Parameters.AddWithValue("@eid", eid);
            cmnd.Parameters.AddWithValue("@password", password);
            cmnd.Parameters.AddWithValue("@EMPID", EMPID);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
