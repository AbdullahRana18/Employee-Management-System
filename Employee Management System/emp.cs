using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Employee_Management_System
{
    internal class emp
    {
        
        public OleDbConnection conn;
        public OleDbCommand cmnd;

        public void CONNADD(string eid ,string fname, string email, string phnum, string edu, string status, string gender)
        {
            string ADD = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            {
                conn = new OleDbConnection(ADD);
                conn.Open();
            }
        }
        public void data(string eid,string FNAME, string EMAIL, string PHNUM, string EDU, string STATUS, string GENDER)
        {
            string add1 = "INSERT INTO [EMPLOYEE]([EMPID],[ENAME],[EMAIL],[PNUM],[EDU],[STATUS],[GENDER])" + "VALUES (@eid,@fullname, @emial ,@phnum,@edu,@status,@gender)";
            cmnd = new OleDbCommand(add1, conn);
            cmnd.Parameters.AddWithValue("@eid", eid);
            cmnd.Parameters.AddWithValue("@FNAME", FNAME);
            cmnd.Parameters.AddWithValue("email", EMAIL);
            cmnd.Parameters.AddWithValue("@phnum", PHNUM);
            cmnd.Parameters.AddWithValue("@edu", EDU);
            cmnd.Parameters.AddWithValue("status", STATUS);
            cmnd.Parameters.AddWithValue("@gender", GENDER);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
       

 
            }
        }

