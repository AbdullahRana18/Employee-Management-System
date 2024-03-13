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
    public partial class SEARCH : Form
    {
        public SEARCH()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashbored d = new Dashbored();
            d.Show();
            this.Hide();
        }

        private void SEARCH_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dashbored d = new Dashbored();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fatchdata f = new fatchdata();
            f.CONNADD();
            //f.LG(textBox1,c,textBox2, textBox4,textBox5, textBox7, textBox3, textBox6,this);
            f.LG(textBox1, textBox2, c,textBox6, textBox7, textBox3,textBox4,textBox5, this);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
