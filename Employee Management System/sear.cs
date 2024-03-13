using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 
namespace Employee_Management_System
{
    internal class sear
    {
        public OleDbConnection conn;
        public OleDbCommand cmnd;

        public void CONNADD(string eid, string fname, string email, string phnum, string edu, string status, string gender)
        {
            string SEARch = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            {
                conn = new OleDbConnection(SEARch);
                conn.Open();
            }
        }

    }
}
