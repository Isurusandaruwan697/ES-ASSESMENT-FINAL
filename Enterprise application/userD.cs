using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_application
{
    public partial class userD : Form
    {
        public userD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label7.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee se_form = new Employee();
            se_form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplyers obj=new Supplyers();
            obj.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock obj=new Stock();
            obj.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Projects obj =Projects new   ();
            obj.Hide();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
