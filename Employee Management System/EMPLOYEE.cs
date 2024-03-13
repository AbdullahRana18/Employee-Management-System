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
    public partial class EMPLOYEE : Form
    {
        public EMPLOYEE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FNAME = textBox1.Text;
            string EMAIL = textBox2.Text;
            string PHNUM = textBox3.Text;
            string EDU = comboBox1.Text;
            string STATUS = comboBox2.Text;
            string GENDER = comboBox3.Text;
            string eid = textBox4.Text;
            emp e1 = new emp();
            e1.CONNADD(eid, FNAME, EMAIL, PHNUM, EDU, STATUS, GENDER);
            if (FNAME == "" || EMAIL == "" || PHNUM == "" || EDU == "" || STATUS == "" || GENDER == "")
                MessageBox.Show("Please Enter Full Data");
            else
            {
                e1.data(eid, FNAME, EMAIL, PHNUM, EDU, STATUS, GENDER);
                MessageBox.Show("Data Added Successfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashbored d1 = new Dashbored();
            d1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //string VIEW = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            //OleDbConnection conn = new OleDbConnection (VIEW);
            //conn.Open();
            //string View1;
            //    View1 = "select * from [EMPLOYEE]";

            //OleDbDataAdapter adapter = new OleDbDataAdapter(View1,conn);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {


            del d = new del();
            d.CONNADD();

            int a = Convert.ToInt16(textBox4.Text);
            if (a > 0)
            {

                d.data(a);

            }
            else
            {

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                string FNAME = textBox1.Text;
                string EMAIL = textBox2.Text;
                string PHNUM = textBox3.Text;
                string EDU = comboBox1.Text;
                string STATUS = comboBox2.Text;
                string GENDER = comboBox3.Text;
                string eid = textBox4.Text;
                edit e1 = new edit();
                e1.CONNADD();
                if (FNAME == "" || EMAIL == "" || PHNUM == "" || EDU == "" || STATUS == "" || GENDER == "")
                    MessageBox.Show("Please Enter Full Data");
                else
                {
                    e1.data(eid, FNAME, EMAIL, PHNUM, EDU, STATUS, GENDER);
                    //MessageBox.Show("Data Updated Successfully");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EMPLOYEE_Load(object sender, EventArgs e)
        {
            string VIEW = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            OleDbConnection conn = new OleDbConnection(VIEW);
            conn.Open();
            string View1;
            View1 = "select * from [EMPLOYEE]";

            OleDbDataAdapter adapter = new OleDbDataAdapter(View1, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }







        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked area is a cell within the row (not the header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

               
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ENAME"].Value.ToString();
                textBox2.Text = row.Cells["EMAIL"].Value.ToString();
                textBox3.Text = row.Cells["PNUM"].Value.ToString();
                textBox4.Text = row.Cells["EMPID"].Value.ToString();
                comboBox1.Text = row.Cells["EDU"].Value.ToString();
                comboBox2.Text = row.Cells["STATUS"].Value.ToString();
                comboBox3.Text = row.Cells["GENDER"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string VIEW = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database1.accdb";
            OleDbConnection conn = new OleDbConnection(VIEW);
            conn.Open();
            string View1;
            View1 = "select * from [EMPLOYEE]";

            OleDbDataAdapter adapter = new OleDbDataAdapter(View1, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //string pic = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //ofd.Filter = "JPEG Images|*.jpg;*.jpeg|PNG Images|*.png|BMP Images|*.bmp|All Files (*.*)|*.*";

            //ofd.FileName = "Image File Name";
            //ofd.Title = "Choose an image...";
            //ofd.AddExtension = true;
            //ofd.FilterIndex = 0;
            //ofd.Multiselect = false;
            //ofd.ValidateNames= true;
            //ofd.InitialDirectory = pic;
            //ofd.RestoreDirectory = true;
            //if(ofd.ShowDialog() == DialogResult.OK)
            //{
            //    this.pictureBox1.Image=Image.FromFile(ofd.FileName);    
            //}
            //else
            //{
            //    return;
            //}

        }
    }
}
