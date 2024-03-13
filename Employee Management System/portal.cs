using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Employee_Management_System
{
    public partial class portal : Form
    {
       
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public portal()
        {
            InitializeComponent();
        }


        public void CONNADD()
        {
            string ADD = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            conn = new OleDbConnection(ADD);
            conn.Open();
            
        }

        private void portal_Load(object sender, EventArgs e)
        {
            
            CONNADD();

            string query = "SELECT * FROM EMPLOYEE WHERE EMPID = ?";
            cmd = new OleDbCommand(query, conn);

           
            cmd.Parameters.AddWithValue("empid", StaticProps.empiid);

            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();

           
            dataTable.Load(reader);

          
            if (dataTable.Rows.Count > 0)
            {
               
                textBox1.Text = dataTable.Rows[0]["ENAME"].ToString();
                textBox2.Text = dataTable.Rows[0]["EMPID"].ToString();
                textBox3.Text = dataTable.Rows[0]["STATUS"].ToString();
                textBox4.Text = dataTable.Rows[0]["SALARY"].ToString();
               
            }

            else
            {
                
                MessageBox.Show("No Record found from given ID");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cheack = MessageBox.Show("Are You Sure You Want to LogOut", "Confirmation Message", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (cheack == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}