using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            salar s = new salar();
            s.CONLOGIN();

            string empId = textBox1.Text;
            string empName = c.Text;
            string status = textBox2.Text;
            string salary = textBox4.Text;
            s.LG(empId, empName, status, salary);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashbored d = new Dashbored();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchbtn s = new searchbtn();
            s.CONNADD();
            s.LG(textBox1,c, textBox2, this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            c.Clear();
            textBox4.Clear();
            textBox2.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
