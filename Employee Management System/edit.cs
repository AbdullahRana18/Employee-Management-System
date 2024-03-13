using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Employee_Management_System
{
    internal class edit
    {

        public string EDIT;
        public OleDbConnection conn;
        public OleDbCommand cmnd;

        public void CONNADD()
        {
            EDIT = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";

            conn = new OleDbConnection(EDIT);
            conn.Open();

        }
        public void data(string eid, string FNAME, string EMAIL, string PHNUM, string EDU, string STATUS, string GENDER)
        {
            string updateQuery = "UPDATE [EMPLOYEE] SET [ENAME] = @fullname, [EMAIL] = @emial, [PNUM] = @phnum, [EDU] = @edu, [STATUS] = @status, [GENDER] = @gender WHERE [EMPID] = @eid";
            cmnd = new OleDbCommand(updateQuery, conn);

            cmnd.Parameters.AddWithValue("@fullname", FNAME);
            cmnd.Parameters.AddWithValue("@emial", EMAIL);
            cmnd.Parameters.AddWithValue("@phnum", PHNUM);
            cmnd.Parameters.AddWithValue("@edu", EDU);
            cmnd.Parameters.AddWithValue("@status", STATUS);
            cmnd.Parameters.AddWithValue("@gender", GENDER);
            cmnd.Parameters.AddWithValue("@eid", eid);
          int e =cmnd.ExecuteNonQuery();
            if (e > 0)
            {
                MessageBox.Show("Data Updated Successfully");

            }
            else
            {
                MessageBox.Show("No data found with the given ID");
            }
        }
    }
}
