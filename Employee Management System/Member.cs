using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_Project
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            FetchMembers();

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

        }
        ScheduleFunctions sf = new ScheduleFunctions();




        public void FetchMembers()
        {
            try
            {
                DataTable dt1 = new DataTable();
                // MySqlCommand x = new("Select RegNo,AppName from members", Connection.GetConnection());
                MySqlCommand x = new("  SELECT members.RegNo,members.AppName,blockstatus.BlockStatus from members Inner join blockstatus on members.RegNo = blockstatus.RegNo where blockstatus.BlockStatus='Active' ", Connection.GetConnection());


                x.CommandType = CommandType.Text;
                int res = x.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(x);
                sda.Fill(dt1);
                dataGridView1.DataSource = dt1;


            }
            catch
            {
                MessageBox.Show("Error Occured in member data ");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            int Row = row.Index;
            MyAccess.GetRegNo = dataGridView1["RegNo", row.Index].Value.ToString();
          

            sf.displayPanel(new CreateChallan2());
        }

        private void dataGridView1_AlternatingRowsDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                searchdata();
            }
            else
            {
                FetchMembers();
            }
        }
        public void searchdata()
        {
            //  string query = "Select RegNo,AppName from members where  RegNo  LIKE '" + textBox1.Text + '%' + "' or   AppName  LIKE '" + textBox1.Text + '%' + "'";
            //or AppName  LIKE '" + textBox1.Text + '%' + "'";

            string query = "SELECT members.RegNo,members.AppName,blockstatus.BlockStatus from members Inner join blockstatus on members.RegNo = blockstatus.RegNo where  members.RegNo  LIKE '%" + textBox1.Text + '%' + "' or   members.AppName  LIKE '%" + textBox1.Text + '%' + "'  And blockstatus.BlockStatus = 'Active'";

            MySqlCommand x = new MySqlCommand(query, Connection.GetConnection());// creating sql instance and connection string
            int result = x.ExecuteNonQuery();// query execution
            MySqlDataAdapter sda = new MySqlDataAdapter(x); // creating data adapter instance
            DataTable dt = new DataTable(); // container for data 
            sda.Fill(dt); // filling sql data into datatable
            dataGridView1.DataSource = dt; // loading data into 
        }
    }

}

