using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class dashboardui : Form
    {
        public dashboardui()
        {
            InitializeComponent();
        }


        public string search;
        public OleDbConnection conn;
        public OleDbCommand cmd;

        public void CONNADD()
        {
            string ADD = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            conn = new OleDbConnection(ADD);
            conn.Open();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Dashbored d = new Dashbored();
            d.Show();
            this.Hide();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardui_Load(object sender, EventArgs e)
        {
            CONNADD();
            string query = "SELECT " +
               "SUM(Salary) AS TotalSalary, " +
               "SUM(IIF(GENDER = 'Male', 1, 0)) AS MaleCount, " +
               "SUM(IIF(GENDER = 'Female', 1, 0)) AS FemaleCount " +
               "FROM EMPLOYEE";
            cmd = new OleDbCommand(query, conn);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                double maleCount = reader.GetDouble(reader.GetOrdinal("MaleCount"));
                double femaleCount = reader.GetDouble(reader.GetOrdinal("FemaleCount"));
                double sumsalary = reader.GetDouble(reader.GetOrdinal("TotalSalary"));
                double total = maleCount + femaleCount;

                label6.Text = $"{total}";

                // Optional: Display counts in individual labels
                label7.Text = $"{maleCount}";
                label8.Text = $"{femaleCount}";
                label9.Text = $"{sumsalary}";
            }

            //reader.Close();
             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }

