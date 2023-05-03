using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_application
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminD obj = new AdminD();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void vender_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  Projects", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
